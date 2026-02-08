using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Mirror;
using Polytoria.Lua;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Datamodel
{
	// Token: 0x020002AC RID: 684
	public class Sound : DynamicInstance
	{
		// Token: 0x06003A31 RID: 14897 RVA: 0x00107434 File Offset: 0x00105634
		// Note: this type is marked as 'beforefieldinit'.
		static Sound()
		{
			Il2CppClassPointerStore<Sound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "Sound");
			Sound.NativeFieldInfoPtr_audioCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "audioCache");
			Sound.NativeFieldInfoPtr_audioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "audioSource");
			Sound.NativeFieldInfoPtr_clip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "clip");
			Sound.NativeFieldInfoPtr_soundID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "soundID");
			Sound.NativeFieldInfoPtr__isPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "_isPlaying");
			Sound.NativeFieldInfoPtr_autoplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "autoplay");
			Sound.NativeFieldInfoPtr_volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "volume");
			Sound.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "time");
			Sound.NativeFieldInfoPtr_loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "loop");
			Sound.NativeFieldInfoPtr_playInWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "playInWorld");
			Sound.NativeFieldInfoPtr_pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "pitch");
			Sound.NativeFieldInfoPtr_maxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "maxDistance");
			Sound.NativeFieldInfoPtr_Loaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "Loaded");
			Sound.NativeFieldInfoPtr_loading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "loading");
			Sound.NativeMethodInfoPtr_get_Playing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672209);
			Sound.NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672210);
			Sound.NativeMethodInfoPtr_get_SoundID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672211);
			Sound.NativeMethodInfoPtr_set_SoundID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672212);
			Sound.NativeMethodInfoPtr_get_Pitch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672213);
			Sound.NativeMethodInfoPtr_set_Pitch_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672214);
			Sound.NativeMethodInfoPtr_get_MaxDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672215);
			Sound.NativeMethodInfoPtr_set_MaxDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672216);
			Sound.NativeMethodInfoPtr_get_Length_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672217);
			Sound.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672218);
			Sound.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672219);
			Sound.NativeMethodInfoPtr_get_Rotation_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672220);
			Sound.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672221);
			Sound.NativeMethodInfoPtr_get_Time_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672222);
			Sound.NativeMethodInfoPtr_set_Time_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672223);
			Sound.NativeMethodInfoPtr_get_Autoplay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672226);
			Sound.NativeMethodInfoPtr_set_Autoplay_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672227);
			Sound.NativeMethodInfoPtr_get_Loop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672228);
			Sound.NativeMethodInfoPtr_set_Loop_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672229);
			Sound.NativeMethodInfoPtr_get_PlayInWorld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672230);
			Sound.NativeMethodInfoPtr_set_PlayInWorld_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672231);
			Sound.NativeMethodInfoPtr_get_Volume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672232);
			Sound.NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672233);
			Sound.NativeMethodInfoPtr_get_NetworksoundID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672255);
			Sound.NativeMethodInfoPtr_set_NetworksoundID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672256);
			Sound.NativeMethodInfoPtr_get_Network_isPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672257);
			Sound.NativeMethodInfoPtr_set_Network_isPlaying_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672258);
			Sound.NativeMethodInfoPtr_get_Networkautoplay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672259);
			Sound.NativeMethodInfoPtr_set_Networkautoplay_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672260);
			Sound.NativeMethodInfoPtr_get_Networkvolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672261);
			Sound.NativeMethodInfoPtr_set_Networkvolume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672262);
			Sound.NativeMethodInfoPtr_get_Networktime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672263);
			Sound.NativeMethodInfoPtr_set_Networktime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672264);
			Sound.NativeMethodInfoPtr_get_Networkloop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672265);
			Sound.NativeMethodInfoPtr_set_Networkloop_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672266);
			Sound.NativeMethodInfoPtr_get_NetworkplayInWorld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672267);
			Sound.NativeMethodInfoPtr_set_NetworkplayInWorld_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672268);
			Sound.NativeMethodInfoPtr_get_Networkpitch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672269);
			Sound.NativeMethodInfoPtr_set_Networkpitch_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672270);
			Sound.NativeMethodInfoPtr_get_NetworkmaxDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672271);
			Sound.NativeMethodInfoPtr_set_NetworkmaxDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672272);
			Sound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672252);
			Sound.NativeMethodInfoPtr_GetAudioClip_Private_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672224);
			Sound.NativeMethodInfoPtr_RpcSetSoundId_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672225);
			Sound.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672234);
			Sound.NativeMethodInfoPtr_PlayOneShot_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672235);
			Sound.NativeMethodInfoPtr_RpcPlayOneShot_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672236);
			Sound.NativeMethodInfoPtr_playC_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672237);
			Sound.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672238);
			Sound.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672239);
			Sound.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672240);
			Sound.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672241);
			Sound.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672242);
			Sound.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672243);
			Sound.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672244);
			Sound.NativeMethodInfoPtr_RpcStop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672245);
			Sound.NativeMethodInfoPtr_RpcPlay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672246);
			Sound.NativeMethodInfoPtr_RpcSetTime_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672247);
			Sound.NativeMethodInfoPtr_RpcSetVolume_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672248);
			Sound.NativeMethodInfoPtr_RpcSetPitch_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672249);
			Sound.NativeMethodInfoPtr_RpcSetMaxDistance_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672250);
			Sound.NativeMethodInfoPtr_RpcChangeBoolProperty_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672251);
			Sound.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672254);
			Sound.NativeMethodInfoPtr_UserCode_RpcSetSoundId__Int32_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672273);
			Sound.NativeMethodInfoPtr_InvokeUserCode_RpcSetSoundId__Int32_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672274);
			Sound.NativeMethodInfoPtr_UserCode_RpcPlayOneShot__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672275);
			Sound.NativeMethodInfoPtr_InvokeUserCode_RpcPlayOneShot__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672276);
			Sound.NativeMethodInfoPtr_UserCode_RpcStop_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672277);
			Sound.NativeMethodInfoPtr_InvokeUserCode_RpcStop_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672278);
			Sound.NativeMethodInfoPtr_UserCode_RpcPlay_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672279);
			Sound.NativeMethodInfoPtr_InvokeUserCode_RpcPlay_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672280);
			Sound.NativeMethodInfoPtr_UserCode_RpcSetTime__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672281);
			Sound.NativeMethodInfoPtr_InvokeUserCode_RpcSetTime__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672282);
			Sound.NativeMethodInfoPtr_UserCode_RpcSetVolume__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672283);
			Sound.NativeMethodInfoPtr_InvokeUserCode_RpcSetVolume__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672284);
			Sound.NativeMethodInfoPtr_UserCode_RpcSetPitch__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672285);
			Sound.NativeMethodInfoPtr_InvokeUserCode_RpcSetPitch__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672286);
			Sound.NativeMethodInfoPtr_UserCode_RpcSetMaxDistance__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672287);
			Sound.NativeMethodInfoPtr_InvokeUserCode_RpcSetMaxDistance__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672288);
			Sound.NativeMethodInfoPtr_UserCode_RpcChangeBoolProperty__Int32__Boolean_Protected_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672289);
			Sound.NativeMethodInfoPtr_InvokeUserCode_RpcChangeBoolProperty__Int32__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672290);
			Sound.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672291);
			Sound.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100672292);
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x06003A32 RID: 14898 RVA: 0x00107BF0 File Offset: 0x00105DF0
		public unsafe bool Playing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_Playing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x06003A33 RID: 14899 RVA: 0x00107C2C File Offset: 0x00105E2C
		public unsafe bool Loading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x06003A34 RID: 14900 RVA: 0x00107C68 File Offset: 0x00105E68
		// (set) Token: 0x06003A35 RID: 14901 RVA: 0x00107CA4 File Offset: 0x00105EA4
		public unsafe int SoundID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_SoundID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 118077, RefRangeEnd = 118079, XrefRangeStart = 118058, XrefRangeEnd = 118077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_set_SoundID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x06003A36 RID: 14902 RVA: 0x00107CE4 File Offset: 0x00105EE4
		// (set) Token: 0x06003A37 RID: 14903 RVA: 0x00107D20 File Offset: 0x00105F20
		public unsafe float Pitch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_Pitch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 118102, RefRangeEnd = 118106, XrefRangeStart = 118079, XrefRangeEnd = 118102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_set_Pitch_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x06003A38 RID: 14904 RVA: 0x00107D60 File Offset: 0x00105F60
		// (set) Token: 0x06003A39 RID: 14905 RVA: 0x00107D9C File Offset: 0x00105F9C
		public unsafe float MaxDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_MaxDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 118129, RefRangeEnd = 118133, XrefRangeStart = 118106, XrefRangeEnd = 118129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_set_MaxDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x06003A3A RID: 14906 RVA: 0x00107DDC File Offset: 0x00105FDC
		public unsafe float Length
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118134, RefRangeEnd = 118135, XrefRangeStart = 118133, XrefRangeEnd = 118134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_Length_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x06003A3B RID: 14907 RVA: 0x00107E18 File Offset: 0x00106018
		// (set) Token: 0x06003A3C RID: 14908 RVA: 0x00107E58 File Offset: 0x00106058
		public new unsafe Vector3 Size
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 118137, RefRangeEnd = 118141, XrefRangeStart = 118135, XrefRangeEnd = 118137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118145, RefRangeEnd = 118146, XrefRangeStart = 118141, XrefRangeEnd = 118145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x06003A3D RID: 14909 RVA: 0x00107E9C File Offset: 0x0010609C
		// (set) Token: 0x06003A3E RID: 14910 RVA: 0x00107EDC File Offset: 0x001060DC
		public new unsafe Vector3 Rotation
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 118137, RefRangeEnd = 118141, XrefRangeStart = 118137, XrefRangeEnd = 118141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_Rotation_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118150, RefRangeEnd = 118151, XrefRangeStart = 118146, XrefRangeEnd = 118150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x06003A3F RID: 14911 RVA: 0x00107F20 File Offset: 0x00106120
		// (set) Token: 0x06003A40 RID: 14912 RVA: 0x00107F5C File Offset: 0x0010615C
		public unsafe float Time
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118153, RefRangeEnd = 118154, XrefRangeStart = 118151, XrefRangeEnd = 118153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_Time_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 118177, RefRangeEnd = 118180, XrefRangeStart = 118154, XrefRangeEnd = 118177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_set_Time_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x06003A41 RID: 14913 RVA: 0x00107F9C File Offset: 0x0010619C
		// (set) Token: 0x06003A42 RID: 14914 RVA: 0x00107FD8 File Offset: 0x001061D8
		public unsafe bool Autoplay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_Autoplay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118183, RefRangeEnd = 118184, XrefRangeStart = 118180, XrefRangeEnd = 118183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_set_Autoplay_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x06003A43 RID: 14915 RVA: 0x00108018 File Offset: 0x00106218
		// (set) Token: 0x06003A44 RID: 14916 RVA: 0x00108054 File Offset: 0x00106254
		public unsafe bool Loop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_Loop_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118189, RefRangeEnd = 118190, XrefRangeStart = 118184, XrefRangeEnd = 118189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_set_Loop_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x06003A45 RID: 14917 RVA: 0x00108094 File Offset: 0x00106294
		// (set) Token: 0x06003A46 RID: 14918 RVA: 0x001080D0 File Offset: 0x001062D0
		public unsafe bool PlayInWorld
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_PlayInWorld_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 118195, RefRangeEnd = 118197, XrefRangeStart = 118190, XrefRangeEnd = 118195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_set_PlayInWorld_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x06003A47 RID: 14919 RVA: 0x00108110 File Offset: 0x00106310
		// (set) Token: 0x06003A48 RID: 14920 RVA: 0x0010814C File Offset: 0x0010634C
		public unsafe float Volume
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118199, RefRangeEnd = 118200, XrefRangeStart = 118197, XrefRangeEnd = 118199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_Volume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 118223, RefRangeEnd = 118227, XrefRangeStart = 118200, XrefRangeEnd = 118223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x06003A49 RID: 14921 RVA: 0x0010818C File Offset: 0x0010638C
		// (set) Token: 0x06003A4A RID: 14922 RVA: 0x001081C8 File Offset: 0x001063C8
		public unsafe int NetworksoundID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_NetworksoundID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 118233, RefRangeEnd = 118236, XrefRangeStart = 118227, XrefRangeEnd = 118233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_set_NetworksoundID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06003A4B RID: 14923 RVA: 0x00108208 File Offset: 0x00106408
		// (set) Token: 0x06003A4C RID: 14924 RVA: 0x00108244 File Offset: 0x00106444
		public unsafe bool Network_isPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_Network_isPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 118242, RefRangeEnd = 118245, XrefRangeStart = 118236, XrefRangeEnd = 118242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_set_Network_isPlaying_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x06003A4D RID: 14925 RVA: 0x00108284 File Offset: 0x00106484
		// (set) Token: 0x06003A4E RID: 14926 RVA: 0x001082C0 File Offset: 0x001064C0
		public unsafe bool Networkautoplay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_Networkautoplay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 118251, RefRangeEnd = 118254, XrefRangeStart = 118245, XrefRangeEnd = 118251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_set_Networkautoplay_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x06003A4F RID: 14927 RVA: 0x00108300 File Offset: 0x00106500
		// (set) Token: 0x06003A50 RID: 14928 RVA: 0x0010833C File Offset: 0x0010653C
		public unsafe float Networkvolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_Networkvolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118254, XrefRangeEnd = 118260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_set_Networkvolume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x06003A51 RID: 14929 RVA: 0x0010837C File Offset: 0x0010657C
		// (set) Token: 0x06003A52 RID: 14930 RVA: 0x001083B8 File Offset: 0x001065B8
		public unsafe float Networktime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_Networktime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118260, XrefRangeEnd = 118266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_set_Networktime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x06003A53 RID: 14931 RVA: 0x001083F8 File Offset: 0x001065F8
		// (set) Token: 0x06003A54 RID: 14932 RVA: 0x00108434 File Offset: 0x00106634
		public unsafe bool Networkloop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_Networkloop_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 118272, RefRangeEnd = 118275, XrefRangeStart = 118266, XrefRangeEnd = 118272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_set_Networkloop_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x06003A55 RID: 14933 RVA: 0x00108474 File Offset: 0x00106674
		// (set) Token: 0x06003A56 RID: 14934 RVA: 0x001084B0 File Offset: 0x001066B0
		public unsafe bool NetworkplayInWorld
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_NetworkplayInWorld_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 118281, RefRangeEnd = 118284, XrefRangeStart = 118275, XrefRangeEnd = 118281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_set_NetworkplayInWorld_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x06003A57 RID: 14935 RVA: 0x001084F0 File Offset: 0x001066F0
		// (set) Token: 0x06003A58 RID: 14936 RVA: 0x0010852C File Offset: 0x0010672C
		public unsafe float Networkpitch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_Networkpitch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118284, XrefRangeEnd = 118290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_set_Networkpitch_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x06003A59 RID: 14937 RVA: 0x0010856C File Offset: 0x0010676C
		// (set) Token: 0x06003A5A RID: 14938 RVA: 0x001085A8 File Offset: 0x001067A8
		public unsafe float NetworkmaxDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_get_NetworkmaxDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118290, XrefRangeEnd = 118296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_set_NetworkmaxDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x001085E8 File Offset: 0x001067E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118296, XrefRangeEnd = 118305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sound()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A5C RID: 14940 RVA: 0x00108624 File Offset: 0x00106824
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 118310, RefRangeEnd = 118312, XrefRangeStart = 118305, XrefRangeEnd = 118310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetAudioClip(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_GetAudioClip_Private_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06003A5D RID: 14941 RVA: 0x00108670 File Offset: 0x00106870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118312, XrefRangeEnd = 118333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetSoundId(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_RpcSetSoundId_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A5E RID: 14942 RVA: 0x001086B0 File Offset: 0x001068B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118361, RefRangeEnd = 118362, XrefRangeStart = 118333, XrefRangeEnd = 118361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A5F RID: 14943 RVA: 0x001086E4 File Offset: 0x001068E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118385, RefRangeEnd = 118386, XrefRangeStart = 118362, XrefRangeEnd = 118385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayOneShot(float volume = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref volume;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_PlayOneShot_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x00108724 File Offset: 0x00106924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118386, XrefRangeEnd = 118407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcPlayOneShot(float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref volume;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_RpcPlayOneShot_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A61 RID: 14945 RVA: 0x00108764 File Offset: 0x00106964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118407, XrefRangeEnd = 118412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator playC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_playC_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003A62 RID: 14946 RVA: 0x001087A4 File Offset: 0x001069A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118435, RefRangeEnd = 118436, XrefRangeStart = 118412, XrefRangeEnd = 118435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A63 RID: 14947 RVA: 0x001087D8 File Offset: 0x001069D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118436, XrefRangeEnd = 118441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sound.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A64 RID: 14948 RVA: 0x00108814 File Offset: 0x00106A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118441, XrefRangeEnd = 118443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sound.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A65 RID: 14949 RVA: 0x00108850 File Offset: 0x00106A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sound.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A66 RID: 14950 RVA: 0x0010888C File Offset: 0x00106A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118443, XrefRangeEnd = 118462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sound.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A67 RID: 14951 RVA: 0x001088DC File Offset: 0x00106ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118462, XrefRangeEnd = 118468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sound.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x00108918 File Offset: 0x00106B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118468, XrefRangeEnd = 118479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sound.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A69 RID: 14953 RVA: 0x00108954 File Offset: 0x00106B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118479, XrefRangeEnd = 118499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_RpcStop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A6A RID: 14954 RVA: 0x00108988 File Offset: 0x00106B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118499, XrefRangeEnd = 118519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcPlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_RpcPlay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x001089BC File Offset: 0x00106BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118519, XrefRangeEnd = 118540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetTime(float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_RpcSetTime_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A6C RID: 14956 RVA: 0x001089FC File Offset: 0x00106BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118540, XrefRangeEnd = 118561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetVolume(float vol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vol;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_RpcSetVolume_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A6D RID: 14957 RVA: 0x00108A3C File Offset: 0x00106C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118561, XrefRangeEnd = 118582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetPitch(float p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_RpcSetPitch_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A6E RID: 14958 RVA: 0x00108A7C File Offset: 0x00106C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118582, XrefRangeEnd = 118603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetMaxDistance(float d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_RpcSetMaxDistance_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A6F RID: 14959 RVA: 0x00108ABC File Offset: 0x00106CBC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 118625, RefRangeEnd = 118630, XrefRangeStart = 118603, XrefRangeEnd = 118625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcChangeBoolProperty(int property, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref property;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_RpcChangeBoolProperty_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A70 RID: 14960 RVA: 0x00108B08 File Offset: 0x00106D08
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sound.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A71 RID: 14961 RVA: 0x00108B50 File Offset: 0x00106D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118630, XrefRangeEnd = 118632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetSoundId__Int32(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_UserCode_RpcSetSoundId__Int32_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A72 RID: 14962 RVA: 0x00108B90 File Offset: 0x00106D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118632, XrefRangeEnd = 118647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetSoundId__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_InvokeUserCode_RpcSetSoundId__Int32_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A73 RID: 14963 RVA: 0x00108BEC File Offset: 0x00106DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118647, XrefRangeEnd = 118649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcPlayOneShot__Single(float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref volume;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_UserCode_RpcPlayOneShot__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A74 RID: 14964 RVA: 0x00108C2C File Offset: 0x00106E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118649, XrefRangeEnd = 118660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcPlayOneShot__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_InvokeUserCode_RpcPlayOneShot__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A75 RID: 14965 RVA: 0x00108C88 File Offset: 0x00106E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118660, XrefRangeEnd = 118775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_UserCode_RpcStop_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A76 RID: 14966 RVA: 0x00108CBC File Offset: 0x00106EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118775, XrefRangeEnd = 118796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcStop(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_InvokeUserCode_RpcStop_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A77 RID: 14967 RVA: 0x00108D18 File Offset: 0x00106F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118796, XrefRangeEnd = 118802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcPlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_UserCode_RpcPlay_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A78 RID: 14968 RVA: 0x00108D4C File Offset: 0x00106F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118802, XrefRangeEnd = 118822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcPlay(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_InvokeUserCode_RpcPlay_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A79 RID: 14969 RVA: 0x00108DA8 File Offset: 0x00106FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118822, XrefRangeEnd = 118824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetTime__Single(float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_UserCode_RpcSetTime__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A7A RID: 14970 RVA: 0x00108DE8 File Offset: 0x00106FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118824, XrefRangeEnd = 118835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetTime__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_InvokeUserCode_RpcSetTime__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A7B RID: 14971 RVA: 0x00108E44 File Offset: 0x00107044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118835, XrefRangeEnd = 118837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetVolume__Single(float vol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vol;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_UserCode_RpcSetVolume__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A7C RID: 14972 RVA: 0x00108E84 File Offset: 0x00107084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118837, XrefRangeEnd = 118848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetVolume__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_InvokeUserCode_RpcSetVolume__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A7D RID: 14973 RVA: 0x00108EE0 File Offset: 0x001070E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118848, XrefRangeEnd = 118850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetPitch__Single(float p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_UserCode_RpcSetPitch__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A7E RID: 14974 RVA: 0x00108F20 File Offset: 0x00107120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118850, XrefRangeEnd = 118861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetPitch__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_InvokeUserCode_RpcSetPitch__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A7F RID: 14975 RVA: 0x00108F7C File Offset: 0x0010717C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118861, XrefRangeEnd = 118863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetMaxDistance__Single(float d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_UserCode_RpcSetMaxDistance__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A80 RID: 14976 RVA: 0x00108FBC File Offset: 0x001071BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118863, XrefRangeEnd = 118874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetMaxDistance__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_InvokeUserCode_RpcSetMaxDistance__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A81 RID: 14977 RVA: 0x00109018 File Offset: 0x00107218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118874, XrefRangeEnd = 118879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcChangeBoolProperty__Int32__Boolean(int property, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref property;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_UserCode_RpcChangeBoolProperty__Int32__Boolean_Protected_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A82 RID: 14978 RVA: 0x00109064 File Offset: 0x00107264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118879, XrefRangeEnd = 118891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcChangeBoolProperty__Int32__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.NativeMethodInfoPtr_InvokeUserCode_RpcChangeBoolProperty__Int32__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A83 RID: 14979 RVA: 0x001090C0 File Offset: 0x001072C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118891, XrefRangeEnd = 118911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sound.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A84 RID: 14980 RVA: 0x0010911C File Offset: 0x0010731C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118911, XrefRangeEnd = 118968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sound.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A85 RID: 14981 RVA: 0x00016852 File Offset: 0x00014A52
		public Sound(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x06003A86 RID: 14982 RVA: 0x00109178 File Offset: 0x00107378
		// (set) Token: 0x06003A87 RID: 14983 RVA: 0x0001685B File Offset: 0x00014A5B
		public unsafe static Dictionary<int, Sound.AudioCacheEntry> audioCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Sound.NativeFieldInfoPtr_audioCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Sound.AudioCacheEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Sound.NativeFieldInfoPtr_audioCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06003A88 RID: 14984 RVA: 0x001091A0 File Offset: 0x001073A0
		// (set) Token: 0x06003A89 RID: 14985 RVA: 0x0001686D File Offset: 0x00014A6D
		public unsafe AudioSource audioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_audioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_audioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06003A8A RID: 14986 RVA: 0x001091D0 File Offset: 0x001073D0
		// (set) Token: 0x06003A8B RID: 14987 RVA: 0x0001688C File Offset: 0x00014A8C
		public unsafe AudioClip clip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_clip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_clip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06003A8C RID: 14988 RVA: 0x00109200 File Offset: 0x00107400
		// (set) Token: 0x06003A8D RID: 14989 RVA: 0x000168AB File Offset: 0x00014AAB
		public unsafe int soundID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_soundID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_soundID)) = value;
			}
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x06003A8E RID: 14990 RVA: 0x00109228 File Offset: 0x00107428
		// (set) Token: 0x06003A8F RID: 14991 RVA: 0x000168C6 File Offset: 0x00014AC6
		public unsafe bool _isPlaying
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr__isPlaying);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr__isPlaying)) = value;
			}
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x06003A90 RID: 14992 RVA: 0x00109250 File Offset: 0x00107450
		// (set) Token: 0x06003A91 RID: 14993 RVA: 0x000168E1 File Offset: 0x00014AE1
		public unsafe bool autoplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_autoplay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_autoplay)) = value;
			}
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x06003A92 RID: 14994 RVA: 0x00109278 File Offset: 0x00107478
		// (set) Token: 0x06003A93 RID: 14995 RVA: 0x000168FC File Offset: 0x00014AFC
		public unsafe float volume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_volume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_volume)) = value;
			}
		}

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x06003A94 RID: 14996 RVA: 0x001092A0 File Offset: 0x001074A0
		// (set) Token: 0x06003A95 RID: 14997 RVA: 0x00016917 File Offset: 0x00014B17
		public unsafe float time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_time)) = value;
			}
		}

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x06003A96 RID: 14998 RVA: 0x001092C8 File Offset: 0x001074C8
		// (set) Token: 0x06003A97 RID: 14999 RVA: 0x00016932 File Offset: 0x00014B32
		public unsafe bool loop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_loop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_loop)) = value;
			}
		}

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x06003A98 RID: 15000 RVA: 0x001092F0 File Offset: 0x001074F0
		// (set) Token: 0x06003A99 RID: 15001 RVA: 0x0001694D File Offset: 0x00014B4D
		public unsafe bool playInWorld
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_playInWorld);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_playInWorld)) = value;
			}
		}

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x06003A9A RID: 15002 RVA: 0x00109318 File Offset: 0x00107518
		// (set) Token: 0x06003A9B RID: 15003 RVA: 0x00016968 File Offset: 0x00014B68
		public unsafe float pitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_pitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_pitch)) = value;
			}
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x06003A9C RID: 15004 RVA: 0x00109340 File Offset: 0x00107540
		// (set) Token: 0x06003A9D RID: 15005 RVA: 0x00016983 File Offset: 0x00014B83
		public unsafe float maxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_maxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_maxDistance)) = value;
			}
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x06003A9E RID: 15006 RVA: 0x00109368 File Offset: 0x00107568
		// (set) Token: 0x06003A9F RID: 15007 RVA: 0x0001699E File Offset: 0x00014B9E
		public unsafe LuaEvent Loaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_Loaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_Loaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x06003AA0 RID: 15008 RVA: 0x00109398 File Offset: 0x00107598
		// (set) Token: 0x06003AA1 RID: 15009 RVA: 0x000169BD File Offset: 0x00014BBD
		public unsafe bool loading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_loading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.NativeFieldInfoPtr_loading)) = value;
			}
		}

		// Token: 0x04002D22 RID: 11554
		private static readonly IntPtr NativeFieldInfoPtr_audioCache;

		// Token: 0x04002D23 RID: 11555
		private static readonly IntPtr NativeFieldInfoPtr_audioSource;

		// Token: 0x04002D24 RID: 11556
		private static readonly IntPtr NativeFieldInfoPtr_clip;

		// Token: 0x04002D25 RID: 11557
		private static readonly IntPtr NativeFieldInfoPtr_soundID;

		// Token: 0x04002D26 RID: 11558
		private static readonly IntPtr NativeFieldInfoPtr__isPlaying;

		// Token: 0x04002D27 RID: 11559
		private static readonly IntPtr NativeFieldInfoPtr_autoplay;

		// Token: 0x04002D28 RID: 11560
		private static readonly IntPtr NativeFieldInfoPtr_volume;

		// Token: 0x04002D29 RID: 11561
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x04002D2A RID: 11562
		private static readonly IntPtr NativeFieldInfoPtr_loop;

		// Token: 0x04002D2B RID: 11563
		private static readonly IntPtr NativeFieldInfoPtr_playInWorld;

		// Token: 0x04002D2C RID: 11564
		private static readonly IntPtr NativeFieldInfoPtr_pitch;

		// Token: 0x04002D2D RID: 11565
		private static readonly IntPtr NativeFieldInfoPtr_maxDistance;

		// Token: 0x04002D2E RID: 11566
		private static readonly IntPtr NativeFieldInfoPtr_Loaded;

		// Token: 0x04002D2F RID: 11567
		private static readonly IntPtr NativeFieldInfoPtr_loading;

		// Token: 0x04002D30 RID: 11568
		private static readonly IntPtr NativeMethodInfoPtr_get_Playing_Public_get_Boolean_0;

		// Token: 0x04002D31 RID: 11569
		private static readonly IntPtr NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0;

		// Token: 0x04002D32 RID: 11570
		private static readonly IntPtr NativeMethodInfoPtr_get_SoundID_Public_get_Int32_0;

		// Token: 0x04002D33 RID: 11571
		private static readonly IntPtr NativeMethodInfoPtr_set_SoundID_Public_set_Void_Int32_0;

		// Token: 0x04002D34 RID: 11572
		private static readonly IntPtr NativeMethodInfoPtr_get_Pitch_Public_get_Single_0;

		// Token: 0x04002D35 RID: 11573
		private static readonly IntPtr NativeMethodInfoPtr_set_Pitch_Public_set_Void_Single_0;

		// Token: 0x04002D36 RID: 11574
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxDistance_Public_get_Single_0;

		// Token: 0x04002D37 RID: 11575
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxDistance_Public_set_Void_Single_0;

		// Token: 0x04002D38 RID: 11576
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Single_0;

		// Token: 0x04002D39 RID: 11577
		private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_get_Vector3_0;

		// Token: 0x04002D3A RID: 11578
		private static readonly IntPtr NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0;

		// Token: 0x04002D3B RID: 11579
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Vector3_0;

		// Token: 0x04002D3C RID: 11580
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Vector3_0;

		// Token: 0x04002D3D RID: 11581
		private static readonly IntPtr NativeMethodInfoPtr_get_Time_Public_get_Single_0;

		// Token: 0x04002D3E RID: 11582
		private static readonly IntPtr NativeMethodInfoPtr_set_Time_Public_set_Void_Single_0;

		// Token: 0x04002D3F RID: 11583
		private static readonly IntPtr NativeMethodInfoPtr_get_Autoplay_Public_get_Boolean_0;

		// Token: 0x04002D40 RID: 11584
		private static readonly IntPtr NativeMethodInfoPtr_set_Autoplay_Public_set_Void_Boolean_0;

		// Token: 0x04002D41 RID: 11585
		private static readonly IntPtr NativeMethodInfoPtr_get_Loop_Public_get_Boolean_0;

		// Token: 0x04002D42 RID: 11586
		private static readonly IntPtr NativeMethodInfoPtr_set_Loop_Public_set_Void_Boolean_0;

		// Token: 0x04002D43 RID: 11587
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayInWorld_Public_get_Boolean_0;

		// Token: 0x04002D44 RID: 11588
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayInWorld_Public_set_Void_Boolean_0;

		// Token: 0x04002D45 RID: 11589
		private static readonly IntPtr NativeMethodInfoPtr_get_Volume_Public_get_Single_0;

		// Token: 0x04002D46 RID: 11590
		private static readonly IntPtr NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0;

		// Token: 0x04002D47 RID: 11591
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworksoundID_Public_get_Int32_0;

		// Token: 0x04002D48 RID: 11592
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworksoundID_Public_set_Void_Int32_0;

		// Token: 0x04002D49 RID: 11593
		private static readonly IntPtr NativeMethodInfoPtr_get_Network_isPlaying_Public_get_Boolean_0;

		// Token: 0x04002D4A RID: 11594
		private static readonly IntPtr NativeMethodInfoPtr_set_Network_isPlaying_Public_set_Void_Boolean_0;

		// Token: 0x04002D4B RID: 11595
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkautoplay_Public_get_Boolean_0;

		// Token: 0x04002D4C RID: 11596
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkautoplay_Public_set_Void_Boolean_0;

		// Token: 0x04002D4D RID: 11597
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkvolume_Public_get_Single_0;

		// Token: 0x04002D4E RID: 11598
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkvolume_Public_set_Void_Single_0;

		// Token: 0x04002D4F RID: 11599
		private static readonly IntPtr NativeMethodInfoPtr_get_Networktime_Public_get_Single_0;

		// Token: 0x04002D50 RID: 11600
		private static readonly IntPtr NativeMethodInfoPtr_set_Networktime_Public_set_Void_Single_0;

		// Token: 0x04002D51 RID: 11601
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkloop_Public_get_Boolean_0;

		// Token: 0x04002D52 RID: 11602
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkloop_Public_set_Void_Boolean_0;

		// Token: 0x04002D53 RID: 11603
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkplayInWorld_Public_get_Boolean_0;

		// Token: 0x04002D54 RID: 11604
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkplayInWorld_Public_set_Void_Boolean_0;

		// Token: 0x04002D55 RID: 11605
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkpitch_Public_get_Single_0;

		// Token: 0x04002D56 RID: 11606
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkpitch_Public_set_Void_Single_0;

		// Token: 0x04002D57 RID: 11607
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkmaxDistance_Public_get_Single_0;

		// Token: 0x04002D58 RID: 11608
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkmaxDistance_Public_set_Void_Single_0;

		// Token: 0x04002D59 RID: 11609
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D5A RID: 11610
		private static readonly IntPtr NativeMethodInfoPtr_GetAudioClip_Private_IEnumerator_Int32_0;

		// Token: 0x04002D5B RID: 11611
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetSoundId_Private_Void_Int32_0;

		// Token: 0x04002D5C RID: 11612
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x04002D5D RID: 11613
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShot_Public_Void_Single_0;

		// Token: 0x04002D5E RID: 11614
		private static readonly IntPtr NativeMethodInfoPtr_RpcPlayOneShot_Public_Void_Single_0;

		// Token: 0x04002D5F RID: 11615
		private static readonly IntPtr NativeMethodInfoPtr_playC_Private_IEnumerator_0;

		// Token: 0x04002D60 RID: 11616
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x04002D61 RID: 11617
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002D62 RID: 11618
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002D63 RID: 11619
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04002D64 RID: 11620
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x04002D65 RID: 11621
		private static readonly IntPtr NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0;

		// Token: 0x04002D66 RID: 11622
		private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0;

		// Token: 0x04002D67 RID: 11623
		private static readonly IntPtr NativeMethodInfoPtr_RpcStop_Private_Void_0;

		// Token: 0x04002D68 RID: 11624
		private static readonly IntPtr NativeMethodInfoPtr_RpcPlay_Private_Void_0;

		// Token: 0x04002D69 RID: 11625
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetTime_Private_Void_Single_0;

		// Token: 0x04002D6A RID: 11626
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetVolume_Private_Void_Single_0;

		// Token: 0x04002D6B RID: 11627
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetPitch_Private_Void_Single_0;

		// Token: 0x04002D6C RID: 11628
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetMaxDistance_Private_Void_Single_0;

		// Token: 0x04002D6D RID: 11629
		private static readonly IntPtr NativeMethodInfoPtr_RpcChangeBoolProperty_Private_Void_Int32_Boolean_0;

		// Token: 0x04002D6E RID: 11630
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002D6F RID: 11631
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetSoundId__Int32_Protected_Void_Int32_0;

		// Token: 0x04002D70 RID: 11632
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetSoundId__Int32_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002D71 RID: 11633
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcPlayOneShot__Single_Protected_Void_Single_0;

		// Token: 0x04002D72 RID: 11634
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcPlayOneShot__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002D73 RID: 11635
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcStop_Protected_Void_0;

		// Token: 0x04002D74 RID: 11636
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcStop_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002D75 RID: 11637
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcPlay_Protected_Void_0;

		// Token: 0x04002D76 RID: 11638
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcPlay_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002D77 RID: 11639
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetTime__Single_Protected_Void_Single_0;

		// Token: 0x04002D78 RID: 11640
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetTime__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002D79 RID: 11641
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetVolume__Single_Protected_Void_Single_0;

		// Token: 0x04002D7A RID: 11642
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetVolume__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002D7B RID: 11643
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetPitch__Single_Protected_Void_Single_0;

		// Token: 0x04002D7C RID: 11644
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetPitch__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002D7D RID: 11645
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetMaxDistance__Single_Protected_Void_Single_0;

		// Token: 0x04002D7E RID: 11646
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetMaxDistance__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002D7F RID: 11647
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcChangeBoolProperty__Int32__Boolean_Protected_Void_Int32_Boolean_0;

		// Token: 0x04002D80 RID: 11648
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcChangeBoolProperty__Int32__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002D81 RID: 11649
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002D82 RID: 11650
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;

		// Token: 0x02000402 RID: 1026
		public sealed class AudioCacheEntry : ValueType
		{
			// Token: 0x06004EAD RID: 20141 RVA: 0x001540A8 File Offset: 0x001522A8
			// Note: this type is marked as 'beforefieldinit'.
			static AudioCacheEntry()
			{
				Il2CppClassPointerStore<Sound.AudioCacheEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sound>.NativeClassPtr, "AudioCacheEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sound.AudioCacheEntry>.NativeClassPtr);
				Sound.AudioCacheEntry.NativeFieldInfoPtr_clip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound.AudioCacheEntry>.NativeClassPtr, "clip");
				Sound.AudioCacheEntry.NativeFieldInfoPtr_loading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound.AudioCacheEntry>.NativeClassPtr, "loading");
			}

			// Token: 0x06004EAE RID: 20142 RVA: 0x0001DDDE File Offset: 0x0001BFDE
			public AudioCacheEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004EAF RID: 20143 RVA: 0x0001DDE7 File Offset: 0x0001BFE7
			public AudioCacheEntry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sound.AudioCacheEntry>.NativeClassPtr))
			{
			}

			// Token: 0x17001A84 RID: 6788
			// (get) Token: 0x06004EB0 RID: 20144 RVA: 0x001540FC File Offset: 0x001522FC
			// (set) Token: 0x06004EB1 RID: 20145 RVA: 0x0001DDF9 File Offset: 0x0001BFF9
			public unsafe AudioClip clip
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.AudioCacheEntry.NativeFieldInfoPtr_clip);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.AudioCacheEntry.NativeFieldInfoPtr_clip), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A85 RID: 6789
			// (get) Token: 0x06004EB2 RID: 20146 RVA: 0x0015412C File Offset: 0x0015232C
			// (set) Token: 0x06004EB3 RID: 20147 RVA: 0x0001DE18 File Offset: 0x0001C018
			public unsafe bool loading
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.AudioCacheEntry.NativeFieldInfoPtr_loading);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.AudioCacheEntry.NativeFieldInfoPtr_loading)) = value;
				}
			}

			// Token: 0x04003CE6 RID: 15590
			private static readonly IntPtr NativeFieldInfoPtr_clip;

			// Token: 0x04003CE7 RID: 15591
			private static readonly IntPtr NativeFieldInfoPtr_loading;
		}

		// Token: 0x02000403 RID: 1027
		[ObfuscatedName("Polytoria.Datamodel.Sound+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004EB4 RID: 20148 RVA: 0x00154154 File Offset: 0x00152354
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<Sound.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sound>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sound.__c__DisplayClass39_0>.NativeClassPtr);
				Sound.__c__DisplayClass39_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound.__c__DisplayClass39_0>.NativeClassPtr, "id");
				Sound.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound.__c__DisplayClass39_0>.NativeClassPtr, 100672293);
				Sound.__c__DisplayClass39_0.NativeMethodInfoPtr__GetAudioClip_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound.__c__DisplayClass39_0>.NativeClassPtr, 100672294);
			}

			// Token: 0x06004EB5 RID: 20149 RVA: 0x001541BC File Offset: 0x001523BC
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sound.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EB6 RID: 20150 RVA: 0x001541F8 File Offset: 0x001523F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117876, XrefRangeEnd = 117883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAudioClip_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound.__c__DisplayClass39_0.NativeMethodInfoPtr__GetAudioClip_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004EB7 RID: 20151 RVA: 0x0001DE33 File Offset: 0x0001C033
			public __c__DisplayClass39_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A86 RID: 6790
			// (get) Token: 0x06004EB8 RID: 20152 RVA: 0x00154234 File Offset: 0x00152434
			// (set) Token: 0x06004EB9 RID: 20153 RVA: 0x0001DE3C File Offset: 0x0001C03C
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.__c__DisplayClass39_0.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound.__c__DisplayClass39_0.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x04003CE8 RID: 15592
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04003CE9 RID: 15593
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003CEA RID: 15594
			private static readonly IntPtr NativeMethodInfoPtr__GetAudioClip_b__0_Internal_Boolean_0;
		}

		// Token: 0x02000404 RID: 1028
		[ObfuscatedName("Polytoria.Datamodel.Sound+<GetAudioClip>d__39")]
		public sealed class _GetAudioClip_d__39 : global::Il2CppSystem.Object
		{
			// Token: 0x06004EBA RID: 20154 RVA: 0x0015425C File Offset: 0x0015245C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAudioClip_d__39()
			{
				Il2CppClassPointerStore<Sound._GetAudioClip_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sound>.NativeClassPtr, "<GetAudioClip>d__39");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sound._GetAudioClip_d__39>.NativeClassPtr);
				Sound._GetAudioClip_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound._GetAudioClip_d__39>.NativeClassPtr, "<>1__state");
				Sound._GetAudioClip_d__39.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound._GetAudioClip_d__39>.NativeClassPtr, "<>2__current");
				Sound._GetAudioClip_d__39.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound._GetAudioClip_d__39>.NativeClassPtr, "id");
				Sound._GetAudioClip_d__39.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound._GetAudioClip_d__39>.NativeClassPtr, "<>4__this");
				Sound._GetAudioClip_d__39.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound._GetAudioClip_d__39>.NativeClassPtr, "<>8__1");
				Sound._GetAudioClip_d__39.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound._GetAudioClip_d__39>.NativeClassPtr, "<uwr>5__2");
				Sound._GetAudioClip_d__39.NativeFieldInfoPtr__uwr2_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound._GetAudioClip_d__39>.NativeClassPtr, "<uwr2>5__3");
				Sound._GetAudioClip_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound._GetAudioClip_d__39>.NativeClassPtr, 100672300);
				Sound._GetAudioClip_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound._GetAudioClip_d__39>.NativeClassPtr, 100672302);
				Sound._GetAudioClip_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound._GetAudioClip_d__39>.NativeClassPtr, 100672295);
				Sound._GetAudioClip_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound._GetAudioClip_d__39>.NativeClassPtr, 100672296);
				Sound._GetAudioClip_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound._GetAudioClip_d__39>.NativeClassPtr, 100672297);
				Sound._GetAudioClip_d__39.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound._GetAudioClip_d__39>.NativeClassPtr, 100672298);
				Sound._GetAudioClip_d__39.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound._GetAudioClip_d__39>.NativeClassPtr, 100672299);
				Sound._GetAudioClip_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound._GetAudioClip_d__39>.NativeClassPtr, 100672301);
			}

			// Token: 0x17001A8E RID: 6798
			// (get) Token: 0x06004EBB RID: 20155 RVA: 0x001543B4 File Offset: 0x001525B4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound._GetAudioClip_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001A8F RID: 6799
			// (get) Token: 0x06004EBC RID: 20156 RVA: 0x001543F4 File Offset: 0x001525F4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound._GetAudioClip_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004EBD RID: 20157 RVA: 0x00154434 File Offset: 0x00152634
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetAudioClip_d__39(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sound._GetAudioClip_d__39>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound._GetAudioClip_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004EBE RID: 20158 RVA: 0x0015447C File Offset: 0x0015267C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117883, XrefRangeEnd = 117893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound._GetAudioClip_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EBF RID: 20159 RVA: 0x001544B0 File Offset: 0x001526B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117893, XrefRangeEnd = 118035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound._GetAudioClip_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004EC0 RID: 20160 RVA: 0x001544EC File Offset: 0x001526EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118035, XrefRangeEnd = 118038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound._GetAudioClip_d__39.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EC1 RID: 20161 RVA: 0x00154520 File Offset: 0x00152720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118038, XrefRangeEnd = 118041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound._GetAudioClip_d__39.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EC2 RID: 20162 RVA: 0x00154554 File Offset: 0x00152754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118041, XrefRangeEnd = 118046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound._GetAudioClip_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EC3 RID: 20163 RVA: 0x0001DE57 File Offset: 0x0001C057
			public _GetAudioClip_d__39(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A87 RID: 6791
			// (get) Token: 0x06004EC4 RID: 20164 RVA: 0x00154588 File Offset: 0x00152788
			// (set) Token: 0x06004EC5 RID: 20165 RVA: 0x0001DE60 File Offset: 0x0001C060
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._GetAudioClip_d__39.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._GetAudioClip_d__39.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A88 RID: 6792
			// (get) Token: 0x06004EC6 RID: 20166 RVA: 0x001545B0 File Offset: 0x001527B0
			// (set) Token: 0x06004EC7 RID: 20167 RVA: 0x0001DE7B File Offset: 0x0001C07B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._GetAudioClip_d__39.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._GetAudioClip_d__39.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A89 RID: 6793
			// (get) Token: 0x06004EC8 RID: 20168 RVA: 0x001545E0 File Offset: 0x001527E0
			// (set) Token: 0x06004EC9 RID: 20169 RVA: 0x0001DE9A File Offset: 0x0001C09A
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._GetAudioClip_d__39.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._GetAudioClip_d__39.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x17001A8A RID: 6794
			// (get) Token: 0x06004ECA RID: 20170 RVA: 0x00154608 File Offset: 0x00152808
			// (set) Token: 0x06004ECB RID: 20171 RVA: 0x0001DEB5 File Offset: 0x0001C0B5
			public unsafe Sound __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._GetAudioClip_d__39.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sound>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._GetAudioClip_d__39.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A8B RID: 6795
			// (get) Token: 0x06004ECC RID: 20172 RVA: 0x00154638 File Offset: 0x00152838
			// (set) Token: 0x06004ECD RID: 20173 RVA: 0x0001DED4 File Offset: 0x0001C0D4
			public unsafe Sound.__c__DisplayClass39_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._GetAudioClip_d__39.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sound.__c__DisplayClass39_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._GetAudioClip_d__39.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A8C RID: 6796
			// (get) Token: 0x06004ECE RID: 20174 RVA: 0x00154668 File Offset: 0x00152868
			// (set) Token: 0x06004ECF RID: 20175 RVA: 0x0001DEF3 File Offset: 0x0001C0F3
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._GetAudioClip_d__39.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._GetAudioClip_d__39.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A8D RID: 6797
			// (get) Token: 0x06004ED0 RID: 20176 RVA: 0x00154698 File Offset: 0x00152898
			// (set) Token: 0x06004ED1 RID: 20177 RVA: 0x0001DF12 File Offset: 0x0001C112
			public unsafe UnityWebRequest _uwr2_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._GetAudioClip_d__39.NativeFieldInfoPtr__uwr2_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._GetAudioClip_d__39.NativeFieldInfoPtr__uwr2_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003CEB RID: 15595
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003CEC RID: 15596
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003CED RID: 15597
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04003CEE RID: 15598
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003CEF RID: 15599
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04003CF0 RID: 15600
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003CF1 RID: 15601
			private static readonly IntPtr NativeFieldInfoPtr__uwr2_5__3;

			// Token: 0x04003CF2 RID: 15602
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003CF3 RID: 15603
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003CF4 RID: 15604
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003CF5 RID: 15605
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003CF6 RID: 15606
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003CF7 RID: 15607
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003CF8 RID: 15608
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04003CF9 RID: 15609
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000405 RID: 1029
		[ObfuscatedName("Polytoria.Datamodel.Sound+<playC>d__56")]
		public sealed class _playC_d__56 : global::Il2CppSystem.Object
		{
			// Token: 0x06004ED2 RID: 20178 RVA: 0x001546C8 File Offset: 0x001528C8
			// Note: this type is marked as 'beforefieldinit'.
			static _playC_d__56()
			{
				Il2CppClassPointerStore<Sound._playC_d__56>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sound>.NativeClassPtr, "<playC>d__56");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sound._playC_d__56>.NativeClassPtr);
				Sound._playC_d__56.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound._playC_d__56>.NativeClassPtr, "<>1__state");
				Sound._playC_d__56.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound._playC_d__56>.NativeClassPtr, "<>2__current");
				Sound._playC_d__56.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound._playC_d__56>.NativeClassPtr, "<>4__this");
				Sound._playC_d__56.NativeFieldInfoPtr__played_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound._playC_d__56>.NativeClassPtr, "<played>5__2");
				Sound._playC_d__56.NativeFieldInfoPtr__timeout_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound._playC_d__56>.NativeClassPtr, "<timeout>5__3");
				Sound._playC_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound._playC_d__56>.NativeClassPtr, 100672306);
				Sound._playC_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound._playC_d__56>.NativeClassPtr, 100672308);
				Sound._playC_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound._playC_d__56>.NativeClassPtr, 100672303);
				Sound._playC_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound._playC_d__56>.NativeClassPtr, 100672304);
				Sound._playC_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound._playC_d__56>.NativeClassPtr, 100672305);
				Sound._playC_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound._playC_d__56>.NativeClassPtr, 100672307);
			}

			// Token: 0x17001A95 RID: 6805
			// (get) Token: 0x06004ED3 RID: 20179 RVA: 0x001547D0 File Offset: 0x001529D0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound._playC_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001A96 RID: 6806
			// (get) Token: 0x06004ED4 RID: 20180 RVA: 0x00154810 File Offset: 0x00152A10
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound._playC_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004ED5 RID: 20181 RVA: 0x00154850 File Offset: 0x00152A50
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _playC_d__56(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sound._playC_d__56>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound._playC_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004ED6 RID: 20182 RVA: 0x00154898 File Offset: 0x00152A98
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound._playC_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004ED7 RID: 20183 RVA: 0x001548CC File Offset: 0x00152ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118046, XrefRangeEnd = 118050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound._playC_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004ED8 RID: 20184 RVA: 0x00154908 File Offset: 0x00152B08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118050, XrefRangeEnd = 118058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sound._playC_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004ED9 RID: 20185 RVA: 0x0001DF31 File Offset: 0x0001C131
			public _playC_d__56(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A90 RID: 6800
			// (get) Token: 0x06004EDA RID: 20186 RVA: 0x0015493C File Offset: 0x00152B3C
			// (set) Token: 0x06004EDB RID: 20187 RVA: 0x0001DF3A File Offset: 0x0001C13A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._playC_d__56.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._playC_d__56.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A91 RID: 6801
			// (get) Token: 0x06004EDC RID: 20188 RVA: 0x00154964 File Offset: 0x00152B64
			// (set) Token: 0x06004EDD RID: 20189 RVA: 0x0001DF55 File Offset: 0x0001C155
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._playC_d__56.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._playC_d__56.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A92 RID: 6802
			// (get) Token: 0x06004EDE RID: 20190 RVA: 0x00154994 File Offset: 0x00152B94
			// (set) Token: 0x06004EDF RID: 20191 RVA: 0x0001DF74 File Offset: 0x0001C174
			public unsafe Sound __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._playC_d__56.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sound>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._playC_d__56.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A93 RID: 6803
			// (get) Token: 0x06004EE0 RID: 20192 RVA: 0x001549C4 File Offset: 0x00152BC4
			// (set) Token: 0x06004EE1 RID: 20193 RVA: 0x0001DF93 File Offset: 0x0001C193
			public unsafe bool _played_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._playC_d__56.NativeFieldInfoPtr__played_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._playC_d__56.NativeFieldInfoPtr__played_5__2)) = value;
				}
			}

			// Token: 0x17001A94 RID: 6804
			// (get) Token: 0x06004EE2 RID: 20194 RVA: 0x001549EC File Offset: 0x00152BEC
			// (set) Token: 0x06004EE3 RID: 20195 RVA: 0x0001DFAE File Offset: 0x0001C1AE
			public unsafe int _timeout_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._playC_d__56.NativeFieldInfoPtr__timeout_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sound._playC_d__56.NativeFieldInfoPtr__timeout_5__3)) = value;
				}
			}

			// Token: 0x04003CFA RID: 15610
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003CFB RID: 15611
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003CFC RID: 15612
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003CFD RID: 15613
			private static readonly IntPtr NativeFieldInfoPtr__played_5__2;

			// Token: 0x04003CFE RID: 15614
			private static readonly IntPtr NativeFieldInfoPtr__timeout_5__3;

			// Token: 0x04003CFF RID: 15615
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D00 RID: 15616
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D01 RID: 15617
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003D02 RID: 15618
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D03 RID: 15619
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003D04 RID: 15620
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
