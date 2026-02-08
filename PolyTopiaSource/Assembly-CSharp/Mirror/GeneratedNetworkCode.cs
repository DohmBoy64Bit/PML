using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Mirror.Discovery;
using Polytoria.Controllers;
using Polytoria.Datamodel;
using Polytoria.Networking;
using Polytoria.Types;
using TMPro;
using UnityEngine;

namespace Mirror
{
	// Token: 0x02000347 RID: 839
	[StructLayout(3, CharSet = 4)]
	public static class GeneratedNetworkCode : global::Il2CppSystem.Object
	{
		// Token: 0x060048C4 RID: 18628 RVA: 0x00141C24 File Offset: 0x0013FE24
		// Note: this type is marked as 'beforefieldinit'.
		static GeneratedNetworkCode()
		{
			Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Mirror", "GeneratedNetworkCode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_TimeSnapshotMessage_Public_Static_TimeSnapshotMessage_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674904);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_TimeSnapshotMessage_Public_Static_Void_NetworkWriter_TimeSnapshotMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674905);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_ReadyMessage_Public_Static_ReadyMessage_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674906);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_ReadyMessage_Public_Static_Void_NetworkWriter_ReadyMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674907);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_NotReadyMessage_Public_Static_NotReadyMessage_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674908);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_NotReadyMessage_Public_Static_Void_NetworkWriter_NotReadyMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674909);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_AddPlayerMessage_Public_Static_AddPlayerMessage_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674910);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_AddPlayerMessage_Public_Static_Void_NetworkWriter_AddPlayerMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674911);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_SceneMessage_Public_Static_SceneMessage_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674912);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_SceneOperation_Public_Static_SceneOperation_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674913);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_SceneMessage_Public_Static_Void_NetworkWriter_SceneMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674914);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_SceneOperation_Public_Static_Void_NetworkWriter_SceneOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674915);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_CommandMessage_Public_Static_CommandMessage_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674916);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_CommandMessage_Public_Static_Void_NetworkWriter_CommandMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674917);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_RpcMessage_Public_Static_RpcMessage_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674918);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_RpcMessage_Public_Static_Void_NetworkWriter_RpcMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674919);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_SpawnMessage_Public_Static_SpawnMessage_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674920);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_SpawnFlags_Public_Static_SpawnFlags_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674921);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_SpawnMessage_Public_Static_Void_NetworkWriter_SpawnMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674922);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_SpawnFlags_Public_Static_Void_NetworkWriter_SpawnFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674923);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_ChangeOwnerMessage_Public_Static_ChangeOwnerMessage_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674924);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_ChangeOwnerMessage_Public_Static_Void_NetworkWriter_ChangeOwnerMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674925);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_ObjectSpawnStartedMessage_Public_Static_ObjectSpawnStartedMessage_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674926);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_ObjectSpawnStartedMessage_Public_Static_Void_NetworkWriter_ObjectSpawnStartedMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674927);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_ObjectSpawnFinishedMessage_Public_Static_ObjectSpawnFinishedMessage_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674928);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_ObjectSpawnFinishedMessage_Public_Static_Void_NetworkWriter_ObjectSpawnFinishedMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674929);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_ObjectDestroyMessage_Public_Static_ObjectDestroyMessage_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674930);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_ObjectDestroyMessage_Public_Static_Void_NetworkWriter_ObjectDestroyMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674931);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_ObjectHideMessage_Public_Static_ObjectHideMessage_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674932);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_ObjectHideMessage_Public_Static_Void_NetworkWriter_ObjectHideMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674933);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_EntityStateMessage_Public_Static_EntityStateMessage_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674934);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_EntityStateMessage_Public_Static_Void_NetworkWriter_EntityStateMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674935);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_NetworkPingMessage_Public_Static_NetworkPingMessage_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674936);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_NetworkPingMessage_Public_Static_Void_NetworkWriter_NetworkPingMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674937);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_NetworkPongMessage_Public_Static_NetworkPongMessage_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674938);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_NetworkPongMessage_Public_Static_Void_NetworkWriter_NetworkPongMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674939);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_Discovery_ServerRequest_Public_Static_ServerRequest_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674940);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_Discovery_ServerRequest_Public_Static_Void_NetworkWriter_ServerRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674941);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_Discovery_ServerResponse_Public_Static_ServerResponse_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674942);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_Discovery_ServerResponse_Public_Static_Void_NetworkWriter_ServerResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674943);
			GeneratedNetworkCode.NativeMethodInfoPtr_Method_Public_Static_AuthRequestMessage_NetworkReader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674944);
			GeneratedNetworkCode.NativeMethodInfoPtr_Method_Public_Static_Void_NetworkWriter_AuthRequestMessage_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674945);
			GeneratedNetworkCode.NativeMethodInfoPtr_Method_Public_Static_AuthResponseMessage_NetworkReader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674946);
			GeneratedNetworkCode.NativeMethodInfoPtr_Method_Public_Static_Void_NetworkWriter_AuthResponseMessage_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674947);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_PartShape_Public_Static_Void_NetworkWriter_PartShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674948);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_PartShape_Public_Static_PartShape_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674949);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_PartMaterial_Public_Static_Void_NetworkWriter_PartMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674950);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_PartMaterial_Public_Static_PartMaterial_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674951);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_UnityEngine_PhysicsMaterialCombine_Public_Static_Void_NetworkWriter_PhysicsMaterialCombine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674952);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_UnityEngine_PhysicsMaterialCombine_Public_Static_PhysicsMaterialCombine_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674953);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Controllers_ImageType_Public_Static_Void_NetworkWriter_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674954);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Controllers_ImageType_Public_Static_ImageType_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674955);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_SkyboxPreset_Public_Static_Void_NetworkWriter_SkyboxPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674956);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_SkyboxPreset_Public_Static_SkyboxPreset_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674957);
			GeneratedNetworkCode.NativeMethodInfoPtr_Method_Public_Static_Void_NetworkWriter_SkyboxSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674958);
			GeneratedNetworkCode.NativeMethodInfoPtr_Method_Public_Static_SkyboxSide_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674959);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_AmbientSource_Public_Static_Void_NetworkWriter_AmbientSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674960);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_AmbientSource_Public_Static_AmbientSource_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674961);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_CollisionType_Public_Static_Void_NetworkWriter_CollisionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674962);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_CollisionType_Public_Static_CollisionType_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674963);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Types_ColorRange_Public_Static_Void_NetworkWriter_ColorRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674964);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_ParticleColorMode_Public_Static_Void_NetworkWriter_ParticleColorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674965);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Types_NumberRange_Public_Static_Void_NetworkWriter_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674966);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_ParticleSimulationSpace_Public_Static_Void_NetworkWriter_ParticleSimulationSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674967);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_ParticleShape_Public_Static_Void_NetworkWriter_ParticleShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674968);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Types_ColorRange_Public_Static_ColorRange_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674969);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_ParticleColorMode_Public_Static_ParticleColorMode_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674970);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Types_NumberRange_Public_Static_NumberRange_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674971);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_ParticleSimulationSpace_Public_Static_ParticleSimulationSpace_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674972);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_ParticleShape_Public_Static_ParticleShape_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674973);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_BodyPart_Public_Static_Void_NetworkWriter_BodyPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674974);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_BodyPart_Public_Static_BodyPart_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674975);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_TMPro_HorizontalAlignmentOptions_Public_Static_Void_NetworkWriter_HorizontalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674976);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_TMPro_HorizontalAlignmentOptions_Public_Static_HorizontalAlignmentOptions_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674977);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_TMPro_VerticalAlignmentOptions_Public_Static_Void_NetworkWriter_VerticalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674978);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_TMPro_VerticalAlignmentOptions_Public_Static_VerticalAlignmentOptions_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674979);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_TextFontPreset_Public_Static_Void_NetworkWriter_TextFontPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674980);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_TextFontPreset_Public_Static_TextFontPreset_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674981);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_TextJustify_Public_Static_Void_NetworkWriter_TextJustify_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674982);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_TextVerticalAlign_Public_Static_Void_NetworkWriter_TextVerticalAlign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674983);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_TextJustify_Public_Static_TextJustify_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674984);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_TextVerticalAlign_Public_Static_TextVerticalAlign_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674985);
			GeneratedNetworkCode.NativeMethodInfoPtr__Write_UnityEngine_TextAnchor_Public_Static_Void_NetworkWriter_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674986);
			GeneratedNetworkCode.NativeMethodInfoPtr__Read_UnityEngine_TextAnchor_Public_Static_TextAnchor_NetworkReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674987);
			GeneratedNetworkCode.NativeMethodInfoPtr_Method_Public_Static_Void_NetworkWriter_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674988);
			GeneratedNetworkCode.NativeMethodInfoPtr_Method_Public_Static_Il2CppStringArray_NetworkReader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674989);
			GeneratedNetworkCode.NativeMethodInfoPtr_InitReadWriters_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedNetworkCode>.NativeClassPtr, 100674990);
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x00142320 File Offset: 0x00140520
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSnapshotMessage _Read_Mirror_TimeSnapshotMessage(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_TimeSnapshotMessage_Public_Static_TimeSnapshotMessage_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeSnapshotMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x00142364 File Offset: 0x00140564
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_TimeSnapshotMessage(NetworkWriter writer, TimeSnapshotMessage value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_TimeSnapshotMessage_Public_Static_Void_NetworkWriter_TimeSnapshotMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x001423AC File Offset: 0x001405AC
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadyMessage _Read_Mirror_ReadyMessage(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_ReadyMessage_Public_Static_ReadyMessage_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadyMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x001423F0 File Offset: 0x001405F0
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_ReadyMessage(NetworkWriter writer, ReadyMessage value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_ReadyMessage_Public_Static_Void_NetworkWriter_ReadyMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x00142438 File Offset: 0x00140638
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NotReadyMessage _Read_Mirror_NotReadyMessage(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_NotReadyMessage_Public_Static_NotReadyMessage_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NotReadyMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x0014247C File Offset: 0x0014067C
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_NotReadyMessage(NetworkWriter writer, NotReadyMessage value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_NotReadyMessage_Public_Static_Void_NetworkWriter_NotReadyMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x001424C4 File Offset: 0x001406C4
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AddPlayerMessage _Read_Mirror_AddPlayerMessage(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_AddPlayerMessage_Public_Static_AddPlayerMessage_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AddPlayerMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x00142508 File Offset: 0x00140708
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_AddPlayerMessage(NetworkWriter writer, AddPlayerMessage value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_AddPlayerMessage_Public_Static_Void_NetworkWriter_AddPlayerMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048CD RID: 18637 RVA: 0x00142550 File Offset: 0x00140750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143679, XrefRangeEnd = 143683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SceneMessage _Read_Mirror_SceneMessage(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_SceneMessage_Public_Static_SceneMessage_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060048CE RID: 18638 RVA: 0x00142594 File Offset: 0x00140794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143683, XrefRangeEnd = 143684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SceneOperation _Read_Mirror_SceneOperation(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_SceneOperation_Public_Static_SceneOperation_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneOperation>(intPtr3) : null;
			}
		}

		// Token: 0x060048CF RID: 18639 RVA: 0x001425D8 File Offset: 0x001407D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143684, XrefRangeEnd = 143687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_SceneMessage(NetworkWriter writer, SceneMessage value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_SceneMessage_Public_Static_Void_NetworkWriter_SceneMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x00142620 File Offset: 0x00140820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143687, XrefRangeEnd = 143688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_SceneOperation(NetworkWriter writer, SceneOperation value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_SceneOperation_Public_Static_Void_NetworkWriter_SceneOperation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x00142668 File Offset: 0x00140868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143688, XrefRangeEnd = 143693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CommandMessage _Read_Mirror_CommandMessage(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_CommandMessage_Public_Static_CommandMessage_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CommandMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060048D2 RID: 18642 RVA: 0x001426AC File Offset: 0x001408AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143693, XrefRangeEnd = 143697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_CommandMessage(NetworkWriter writer, CommandMessage value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_CommandMessage_Public_Static_Void_NetworkWriter_CommandMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x001426F4 File Offset: 0x001408F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RpcMessage _Read_Mirror_RpcMessage(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_RpcMessage_Public_Static_RpcMessage_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RpcMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x00142738 File Offset: 0x00140938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_RpcMessage(NetworkWriter writer, RpcMessage value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_RpcMessage_Public_Static_Void_NetworkWriter_RpcMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D5 RID: 18645 RVA: 0x00142780 File Offset: 0x00140980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143697, XrefRangeEnd = 143706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpawnMessage _Read_Mirror_SpawnMessage(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_SpawnMessage_Public_Static_SpawnMessage_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpawnMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x001427C4 File Offset: 0x001409C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpawnFlags _Read_Mirror_SpawnFlags(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_SpawnFlags_Public_Static_SpawnFlags_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpawnFlags>(intPtr3) : null;
			}
		}

		// Token: 0x060048D7 RID: 18647 RVA: 0x00142808 File Offset: 0x00140A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143706, XrefRangeEnd = 143714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_SpawnMessage(NetworkWriter writer, SpawnMessage value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_SpawnMessage_Public_Static_Void_NetworkWriter_SpawnMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D8 RID: 18648 RVA: 0x00142850 File Offset: 0x00140A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_SpawnFlags(NetworkWriter writer, SpawnFlags value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_SpawnFlags_Public_Static_Void_NetworkWriter_SpawnFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D9 RID: 18649 RVA: 0x00142898 File Offset: 0x00140A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143714, XrefRangeEnd = 143716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ChangeOwnerMessage _Read_Mirror_ChangeOwnerMessage(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_ChangeOwnerMessage_Public_Static_ChangeOwnerMessage_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChangeOwnerMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060048DA RID: 18650 RVA: 0x001428DC File Offset: 0x00140ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143716, XrefRangeEnd = 143718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_ChangeOwnerMessage(NetworkWriter writer, ChangeOwnerMessage value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_ChangeOwnerMessage_Public_Static_Void_NetworkWriter_ChangeOwnerMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048DB RID: 18651 RVA: 0x00142924 File Offset: 0x00140B24
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectSpawnStartedMessage _Read_Mirror_ObjectSpawnStartedMessage(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_ObjectSpawnStartedMessage_Public_Static_ObjectSpawnStartedMessage_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSpawnStartedMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060048DC RID: 18652 RVA: 0x00142968 File Offset: 0x00140B68
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_ObjectSpawnStartedMessage(NetworkWriter writer, ObjectSpawnStartedMessage value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_ObjectSpawnStartedMessage_Public_Static_Void_NetworkWriter_ObjectSpawnStartedMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048DD RID: 18653 RVA: 0x001429B0 File Offset: 0x00140BB0
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectSpawnFinishedMessage _Read_Mirror_ObjectSpawnFinishedMessage(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_ObjectSpawnFinishedMessage_Public_Static_ObjectSpawnFinishedMessage_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSpawnFinishedMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060048DE RID: 18654 RVA: 0x001429F4 File Offset: 0x00140BF4
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_ObjectSpawnFinishedMessage(NetworkWriter writer, ObjectSpawnFinishedMessage value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_ObjectSpawnFinishedMessage_Public_Static_Void_NetworkWriter_ObjectSpawnFinishedMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048DF RID: 18655 RVA: 0x00142A3C File Offset: 0x00140C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143718, XrefRangeEnd = 143719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectDestroyMessage _Read_Mirror_ObjectDestroyMessage(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_ObjectDestroyMessage_Public_Static_ObjectDestroyMessage_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectDestroyMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060048E0 RID: 18656 RVA: 0x00142A80 File Offset: 0x00140C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143719, XrefRangeEnd = 143720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_ObjectDestroyMessage(NetworkWriter writer, ObjectDestroyMessage value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_ObjectDestroyMessage_Public_Static_Void_NetworkWriter_ObjectDestroyMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048E1 RID: 18657 RVA: 0x00142AC8 File Offset: 0x00140CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectHideMessage _Read_Mirror_ObjectHideMessage(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_ObjectHideMessage_Public_Static_ObjectHideMessage_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectHideMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060048E2 RID: 18658 RVA: 0x00142B0C File Offset: 0x00140D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_ObjectHideMessage(NetworkWriter writer, ObjectHideMessage value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_ObjectHideMessage_Public_Static_Void_NetworkWriter_ObjectHideMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048E3 RID: 18659 RVA: 0x00142B54 File Offset: 0x00140D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143720, XrefRangeEnd = 143723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EntityStateMessage _Read_Mirror_EntityStateMessage(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_EntityStateMessage_Public_Static_EntityStateMessage_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityStateMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060048E4 RID: 18660 RVA: 0x00142B98 File Offset: 0x00140D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143723, XrefRangeEnd = 143725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_EntityStateMessage(NetworkWriter writer, EntityStateMessage value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_EntityStateMessage_Public_Static_Void_NetworkWriter_EntityStateMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048E5 RID: 18661 RVA: 0x00142BE0 File Offset: 0x00140DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143725, XrefRangeEnd = 143727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetworkPingMessage _Read_Mirror_NetworkPingMessage(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_NetworkPingMessage_Public_Static_NetworkPingMessage_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkPingMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060048E6 RID: 18662 RVA: 0x00142C24 File Offset: 0x00140E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143727, XrefRangeEnd = 143729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_NetworkPingMessage(NetworkWriter writer, NetworkPingMessage value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_NetworkPingMessage_Public_Static_Void_NetworkWriter_NetworkPingMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x00142C6C File Offset: 0x00140E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143729, XrefRangeEnd = 143732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetworkPongMessage _Read_Mirror_NetworkPongMessage(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_NetworkPongMessage_Public_Static_NetworkPongMessage_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkPongMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x00142CB0 File Offset: 0x00140EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143732, XrefRangeEnd = 143735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_NetworkPongMessage(NetworkWriter writer, NetworkPongMessage value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_NetworkPongMessage_Public_Static_Void_NetworkWriter_NetworkPongMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048E9 RID: 18665 RVA: 0x00142CF8 File Offset: 0x00140EF8
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServerRequest _Read_Mirror_Discovery_ServerRequest(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_Discovery_ServerRequest_Public_Static_ServerRequest_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerRequest>(intPtr3) : null;
			}
		}

		// Token: 0x060048EA RID: 18666 RVA: 0x00142D3C File Offset: 0x00140F3C
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_Discovery_ServerRequest(NetworkWriter writer, ServerRequest value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_Discovery_ServerRequest_Public_Static_Void_NetworkWriter_ServerRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048EB RID: 18667 RVA: 0x00142D84 File Offset: 0x00140F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143735, XrefRangeEnd = 143738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServerResponse _Read_Mirror_Discovery_ServerResponse(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Mirror_Discovery_ServerResponse_Public_Static_ServerResponse_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerResponse>(intPtr3) : null;
			}
		}

		// Token: 0x060048EC RID: 18668 RVA: 0x00142DC8 File Offset: 0x00140FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143738, XrefRangeEnd = 143740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Mirror_Discovery_ServerResponse(NetworkWriter writer, ServerResponse value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Mirror_Discovery_ServerResponse_Public_Static_Void_NetworkWriter_ServerResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048ED RID: 18669 RVA: 0x00142E10 File Offset: 0x00141010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143740, XrefRangeEnd = 143743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PTAuthenticator.AuthRequestMessage Method_Public_Static_AuthRequestMessage_NetworkReader_PDM_0(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr_Method_Public_Static_AuthRequestMessage_NetworkReader_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new PTAuthenticator.AuthRequestMessage(intPtr);
			}
		}

		// Token: 0x060048EE RID: 18670 RVA: 0x00142E4C File Offset: 0x0014104C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143743, XrefRangeEnd = 143745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_NetworkWriter_AuthRequestMessage_PDM_0(NetworkWriter writer, PTAuthenticator.AuthRequestMessage value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr_Method_Public_Static_Void_NetworkWriter_AuthRequestMessage_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048EF RID: 18671 RVA: 0x00142E9C File Offset: 0x0014109C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143745, XrefRangeEnd = 143749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PTAuthenticator.AuthResponseMessage Method_Public_Static_AuthResponseMessage_NetworkReader_PDM_0(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr_Method_Public_Static_AuthResponseMessage_NetworkReader_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new PTAuthenticator.AuthResponseMessage(intPtr);
			}
		}

		// Token: 0x060048F0 RID: 18672 RVA: 0x00142ED8 File Offset: 0x001410D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143749, XrefRangeEnd = 143752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_NetworkWriter_AuthResponseMessage_PDM_0(NetworkWriter writer, PTAuthenticator.AuthResponseMessage value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr_Method_Public_Static_Void_NetworkWriter_AuthResponseMessage_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048F1 RID: 18673 RVA: 0x00142F28 File Offset: 0x00141128
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 143753, RefRangeEnd = 143815, XrefRangeStart = 143752, XrefRangeEnd = 143753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Polytoria_Datamodel_PartShape(NetworkWriter writer, PartShape value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_PartShape_Public_Static_Void_NetworkWriter_PartShape_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048F2 RID: 18674 RVA: 0x00142F70 File Offset: 0x00141170
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143870, XrefRangeStart = 143815, XrefRangeEnd = 143816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PartShape _Read_Polytoria_Datamodel_PartShape(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_PartShape_Public_Static_PartShape_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PartShape>(intPtr3) : null;
			}
		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x00142FB4 File Offset: 0x001411B4
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 143753, RefRangeEnd = 143815, XrefRangeStart = 143753, XrefRangeEnd = 143815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Polytoria_Datamodel_PartMaterial(NetworkWriter writer, PartMaterial value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_PartMaterial_Public_Static_Void_NetworkWriter_PartMaterial_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048F4 RID: 18676 RVA: 0x00142FFC File Offset: 0x001411FC
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143870, XrefRangeStart = 143816, XrefRangeEnd = 143870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PartMaterial _Read_Polytoria_Datamodel_PartMaterial(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_PartMaterial_Public_Static_PartMaterial_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PartMaterial>(intPtr3) : null;
			}
		}

		// Token: 0x060048F5 RID: 18677 RVA: 0x00143040 File Offset: 0x00141240
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 143753, RefRangeEnd = 143815, XrefRangeStart = 143753, XrefRangeEnd = 143815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_UnityEngine_PhysicsMaterialCombine(NetworkWriter writer, PhysicsMaterialCombine value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_UnityEngine_PhysicsMaterialCombine_Public_Static_Void_NetworkWriter_PhysicsMaterialCombine_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048F6 RID: 18678 RVA: 0x00143088 File Offset: 0x00141288
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143870, XrefRangeStart = 143816, XrefRangeEnd = 143870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PhysicsMaterialCombine _Read_UnityEngine_PhysicsMaterialCombine(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_UnityEngine_PhysicsMaterialCombine_Public_Static_PhysicsMaterialCombine_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PhysicsMaterialCombine>(intPtr3) : null;
			}
		}

		// Token: 0x060048F7 RID: 18679 RVA: 0x001430CC File Offset: 0x001412CC
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 143753, RefRangeEnd = 143815, XrefRangeStart = 143753, XrefRangeEnd = 143815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Polytoria_Controllers_ImageType(NetworkWriter writer, ImageType value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Controllers_ImageType_Public_Static_Void_NetworkWriter_ImageType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048F8 RID: 18680 RVA: 0x00143114 File Offset: 0x00141314
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143870, XrefRangeStart = 143816, XrefRangeEnd = 143870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ImageType _Read_Polytoria_Controllers_ImageType(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Controllers_ImageType_Public_Static_ImageType_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ImageType>(intPtr3) : null;
			}
		}

		// Token: 0x060048F9 RID: 18681 RVA: 0x00143158 File Offset: 0x00141358
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 143753, RefRangeEnd = 143815, XrefRangeStart = 143753, XrefRangeEnd = 143815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Polytoria_Datamodel_SkyboxPreset(NetworkWriter writer, SkyboxPreset value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_SkyboxPreset_Public_Static_Void_NetworkWriter_SkyboxPreset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048FA RID: 18682 RVA: 0x001431A0 File Offset: 0x001413A0
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143870, XrefRangeStart = 143816, XrefRangeEnd = 143870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SkyboxPreset _Read_Polytoria_Datamodel_SkyboxPreset(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_SkyboxPreset_Public_Static_SkyboxPreset_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyboxPreset>(intPtr3) : null;
			}
		}

		// Token: 0x060048FB RID: 18683 RVA: 0x001431E4 File Offset: 0x001413E4
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 143753, RefRangeEnd = 143815, XrefRangeStart = 143753, XrefRangeEnd = 143815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_NetworkWriter_SkyboxSide_0(NetworkWriter writer, ImageSky.SkyboxSide value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr_Method_Public_Static_Void_NetworkWriter_SkyboxSide_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048FC RID: 18684 RVA: 0x00143228 File Offset: 0x00141428
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143870, XrefRangeStart = 143816, XrefRangeEnd = 143870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ImageSky.SkyboxSide Method_Public_Static_SkyboxSide_NetworkReader_0(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr_Method_Public_Static_SkyboxSide_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060048FD RID: 18685 RVA: 0x0014326C File Offset: 0x0014146C
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 143753, RefRangeEnd = 143815, XrefRangeStart = 143753, XrefRangeEnd = 143815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Polytoria_Datamodel_AmbientSource(NetworkWriter writer, AmbientSource value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_AmbientSource_Public_Static_Void_NetworkWriter_AmbientSource_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x001432B4 File Offset: 0x001414B4
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143870, XrefRangeStart = 143816, XrefRangeEnd = 143870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AmbientSource _Read_Polytoria_Datamodel_AmbientSource(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_AmbientSource_Public_Static_AmbientSource_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AmbientSource>(intPtr3) : null;
			}
		}

		// Token: 0x060048FF RID: 18687 RVA: 0x001432F8 File Offset: 0x001414F8
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 143753, RefRangeEnd = 143815, XrefRangeStart = 143753, XrefRangeEnd = 143815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Polytoria_Datamodel_CollisionType(NetworkWriter writer, CollisionType value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_CollisionType_Public_Static_Void_NetworkWriter_CollisionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x00143340 File Offset: 0x00141540
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143870, XrefRangeStart = 143816, XrefRangeEnd = 143870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CollisionType _Read_Polytoria_Datamodel_CollisionType(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_CollisionType_Public_Static_CollisionType_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CollisionType>(intPtr3) : null;
			}
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x00143384 File Offset: 0x00141584
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 143872, RefRangeEnd = 143874, XrefRangeStart = 143870, XrefRangeEnd = 143872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Polytoria_Types_ColorRange(NetworkWriter writer, ColorRange value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Types_ColorRange_Public_Static_Void_NetworkWriter_ColorRange_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x001433CC File Offset: 0x001415CC
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 143753, RefRangeEnd = 143815, XrefRangeStart = 143753, XrefRangeEnd = 143815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Polytoria_Datamodel_ParticleColorMode(NetworkWriter writer, ParticleColorMode value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_ParticleColorMode_Public_Static_Void_NetworkWriter_ParticleColorMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x00143414 File Offset: 0x00141614
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 143876, RefRangeEnd = 143886, XrefRangeStart = 143874, XrefRangeEnd = 143876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Polytoria_Types_NumberRange(NetworkWriter writer, NumberRange value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Types_NumberRange_Public_Static_Void_NetworkWriter_NumberRange_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004904 RID: 18692 RVA: 0x0014345C File Offset: 0x0014165C
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 143753, RefRangeEnd = 143815, XrefRangeStart = 143753, XrefRangeEnd = 143815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Polytoria_Datamodel_ParticleSimulationSpace(NetworkWriter writer, ParticleSimulationSpace value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_ParticleSimulationSpace_Public_Static_Void_NetworkWriter_ParticleSimulationSpace_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x001434A4 File Offset: 0x001416A4
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 143753, RefRangeEnd = 143815, XrefRangeStart = 143753, XrefRangeEnd = 143815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Polytoria_Datamodel_ParticleShape(NetworkWriter writer, ParticleShape value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_ParticleShape_Public_Static_Void_NetworkWriter_ParticleShape_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004906 RID: 18694 RVA: 0x001434EC File Offset: 0x001416EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 143888, RefRangeEnd = 143890, XrefRangeStart = 143886, XrefRangeEnd = 143888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ColorRange _Read_Polytoria_Types_ColorRange(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Types_ColorRange_Public_Static_ColorRange_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColorRange>(intPtr3) : null;
			}
		}

		// Token: 0x06004907 RID: 18695 RVA: 0x00143530 File Offset: 0x00141730
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143870, XrefRangeStart = 143816, XrefRangeEnd = 143870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParticleColorMode _Read_Polytoria_Datamodel_ParticleColorMode(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_ParticleColorMode_Public_Static_ParticleColorMode_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParticleColorMode>(intPtr3) : null;
			}
		}

		// Token: 0x06004908 RID: 18696 RVA: 0x00143574 File Offset: 0x00141774
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 143892, RefRangeEnd = 143902, XrefRangeStart = 143890, XrefRangeEnd = 143892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NumberRange _Read_Polytoria_Types_NumberRange(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Types_NumberRange_Public_Static_NumberRange_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr3) : null;
			}
		}

		// Token: 0x06004909 RID: 18697 RVA: 0x001435B8 File Offset: 0x001417B8
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143870, XrefRangeStart = 143816, XrefRangeEnd = 143870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParticleSimulationSpace _Read_Polytoria_Datamodel_ParticleSimulationSpace(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_ParticleSimulationSpace_Public_Static_ParticleSimulationSpace_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParticleSimulationSpace>(intPtr3) : null;
			}
		}

		// Token: 0x0600490A RID: 18698 RVA: 0x001435FC File Offset: 0x001417FC
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143870, XrefRangeStart = 143816, XrefRangeEnd = 143870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParticleShape _Read_Polytoria_Datamodel_ParticleShape(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_ParticleShape_Public_Static_ParticleShape_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParticleShape>(intPtr3) : null;
			}
		}

		// Token: 0x0600490B RID: 18699 RVA: 0x00143640 File Offset: 0x00141840
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 143753, RefRangeEnd = 143815, XrefRangeStart = 143753, XrefRangeEnd = 143815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Polytoria_Datamodel_BodyPart(NetworkWriter writer, BodyPart value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_BodyPart_Public_Static_Void_NetworkWriter_BodyPart_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600490C RID: 18700 RVA: 0x00143688 File Offset: 0x00141888
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143870, XrefRangeStart = 143816, XrefRangeEnd = 143870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BodyPart _Read_Polytoria_Datamodel_BodyPart(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_BodyPart_Public_Static_BodyPart_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BodyPart>(intPtr3) : null;
			}
		}

		// Token: 0x0600490D RID: 18701 RVA: 0x001436CC File Offset: 0x001418CC
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 143753, RefRangeEnd = 143815, XrefRangeStart = 143753, XrefRangeEnd = 143815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_TMPro_HorizontalAlignmentOptions(NetworkWriter writer, HorizontalAlignmentOptions value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_TMPro_HorizontalAlignmentOptions_Public_Static_Void_NetworkWriter_HorizontalAlignmentOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600490E RID: 18702 RVA: 0x00143714 File Offset: 0x00141914
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143870, XrefRangeStart = 143816, XrefRangeEnd = 143870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HorizontalAlignmentOptions _Read_TMPro_HorizontalAlignmentOptions(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_TMPro_HorizontalAlignmentOptions_Public_Static_HorizontalAlignmentOptions_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HorizontalAlignmentOptions>(intPtr3) : null;
			}
		}

		// Token: 0x0600490F RID: 18703 RVA: 0x00143758 File Offset: 0x00141958
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 143753, RefRangeEnd = 143815, XrefRangeStart = 143753, XrefRangeEnd = 143815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_TMPro_VerticalAlignmentOptions(NetworkWriter writer, VerticalAlignmentOptions value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_TMPro_VerticalAlignmentOptions_Public_Static_Void_NetworkWriter_VerticalAlignmentOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004910 RID: 18704 RVA: 0x001437A0 File Offset: 0x001419A0
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143870, XrefRangeStart = 143816, XrefRangeEnd = 143870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VerticalAlignmentOptions _Read_TMPro_VerticalAlignmentOptions(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_TMPro_VerticalAlignmentOptions_Public_Static_VerticalAlignmentOptions_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VerticalAlignmentOptions>(intPtr3) : null;
			}
		}

		// Token: 0x06004911 RID: 18705 RVA: 0x001437E4 File Offset: 0x001419E4
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 143753, RefRangeEnd = 143815, XrefRangeStart = 143753, XrefRangeEnd = 143815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Polytoria_Datamodel_TextFontPreset(NetworkWriter writer, TextFontPreset value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_TextFontPreset_Public_Static_Void_NetworkWriter_TextFontPreset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004912 RID: 18706 RVA: 0x0014382C File Offset: 0x00141A2C
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143870, XrefRangeStart = 143816, XrefRangeEnd = 143870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextFontPreset _Read_Polytoria_Datamodel_TextFontPreset(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_TextFontPreset_Public_Static_TextFontPreset_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextFontPreset>(intPtr3) : null;
			}
		}

		// Token: 0x06004913 RID: 18707 RVA: 0x00143870 File Offset: 0x00141A70
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 143753, RefRangeEnd = 143815, XrefRangeStart = 143753, XrefRangeEnd = 143815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Polytoria_Datamodel_TextJustify(NetworkWriter writer, TextJustify value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_TextJustify_Public_Static_Void_NetworkWriter_TextJustify_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x001438B8 File Offset: 0x00141AB8
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 143753, RefRangeEnd = 143815, XrefRangeStart = 143753, XrefRangeEnd = 143815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_Polytoria_Datamodel_TextVerticalAlign(NetworkWriter writer, TextVerticalAlign value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_Polytoria_Datamodel_TextVerticalAlign_Public_Static_Void_NetworkWriter_TextVerticalAlign_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x00143900 File Offset: 0x00141B00
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143870, XrefRangeStart = 143816, XrefRangeEnd = 143870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextJustify _Read_Polytoria_Datamodel_TextJustify(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_TextJustify_Public_Static_TextJustify_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextJustify>(intPtr3) : null;
			}
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x00143944 File Offset: 0x00141B44
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143870, XrefRangeStart = 143816, XrefRangeEnd = 143870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextVerticalAlign _Read_Polytoria_Datamodel_TextVerticalAlign(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_Polytoria_Datamodel_TextVerticalAlign_Public_Static_TextVerticalAlign_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextVerticalAlign>(intPtr3) : null;
			}
		}

		// Token: 0x06004917 RID: 18711 RVA: 0x00143988 File Offset: 0x00141B88
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 143753, RefRangeEnd = 143815, XrefRangeStart = 143753, XrefRangeEnd = 143815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Write_UnityEngine_TextAnchor(NetworkWriter writer, TextAnchor value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Write_UnityEngine_TextAnchor_Public_Static_Void_NetworkWriter_TextAnchor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004918 RID: 18712 RVA: 0x001439D0 File Offset: 0x00141BD0
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 143816, RefRangeEnd = 143870, XrefRangeStart = 143816, XrefRangeEnd = 143870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextAnchor _Read_UnityEngine_TextAnchor(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr__Read_UnityEngine_TextAnchor_Public_Static_TextAnchor_NetworkReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextAnchor>(intPtr3) : null;
			}
		}

		// Token: 0x06004919 RID: 18713 RVA: 0x00143A14 File Offset: 0x00141C14
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 143905, RefRangeEnd = 143909, XrefRangeStart = 143902, XrefRangeEnd = 143905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_NetworkWriter_Il2CppStringArray_0(NetworkWriter writer, Il2CppStringArray value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr_Method_Public_Static_Void_NetworkWriter_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600491A RID: 18714 RVA: 0x00143A5C File Offset: 0x00141C5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 143912, RefRangeEnd = 143914, XrefRangeStart = 143909, XrefRangeEnd = 143912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray Method_Public_Static_Il2CppStringArray_NetworkReader_PDM_0(NetworkReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr_Method_Public_Static_Il2CppStringArray_NetworkReader_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600491B RID: 18715 RVA: 0x00143AA0 File Offset: 0x00141CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143914, XrefRangeEnd = 146279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitReadWriters()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedNetworkCode.NativeMethodInfoPtr_InitReadWriters_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600491C RID: 18716 RVA: 0x0001B0FA File Offset: 0x000192FA
		public GeneratedNetworkCode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003850 RID: 14416
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_TimeSnapshotMessage_Public_Static_TimeSnapshotMessage_NetworkReader_0;

		// Token: 0x04003851 RID: 14417
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_TimeSnapshotMessage_Public_Static_Void_NetworkWriter_TimeSnapshotMessage_0;

		// Token: 0x04003852 RID: 14418
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_ReadyMessage_Public_Static_ReadyMessage_NetworkReader_0;

		// Token: 0x04003853 RID: 14419
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_ReadyMessage_Public_Static_Void_NetworkWriter_ReadyMessage_0;

		// Token: 0x04003854 RID: 14420
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_NotReadyMessage_Public_Static_NotReadyMessage_NetworkReader_0;

		// Token: 0x04003855 RID: 14421
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_NotReadyMessage_Public_Static_Void_NetworkWriter_NotReadyMessage_0;

		// Token: 0x04003856 RID: 14422
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_AddPlayerMessage_Public_Static_AddPlayerMessage_NetworkReader_0;

		// Token: 0x04003857 RID: 14423
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_AddPlayerMessage_Public_Static_Void_NetworkWriter_AddPlayerMessage_0;

		// Token: 0x04003858 RID: 14424
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_SceneMessage_Public_Static_SceneMessage_NetworkReader_0;

		// Token: 0x04003859 RID: 14425
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_SceneOperation_Public_Static_SceneOperation_NetworkReader_0;

		// Token: 0x0400385A RID: 14426
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_SceneMessage_Public_Static_Void_NetworkWriter_SceneMessage_0;

		// Token: 0x0400385B RID: 14427
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_SceneOperation_Public_Static_Void_NetworkWriter_SceneOperation_0;

		// Token: 0x0400385C RID: 14428
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_CommandMessage_Public_Static_CommandMessage_NetworkReader_0;

		// Token: 0x0400385D RID: 14429
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_CommandMessage_Public_Static_Void_NetworkWriter_CommandMessage_0;

		// Token: 0x0400385E RID: 14430
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_RpcMessage_Public_Static_RpcMessage_NetworkReader_0;

		// Token: 0x0400385F RID: 14431
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_RpcMessage_Public_Static_Void_NetworkWriter_RpcMessage_0;

		// Token: 0x04003860 RID: 14432
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_SpawnMessage_Public_Static_SpawnMessage_NetworkReader_0;

		// Token: 0x04003861 RID: 14433
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_SpawnFlags_Public_Static_SpawnFlags_NetworkReader_0;

		// Token: 0x04003862 RID: 14434
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_SpawnMessage_Public_Static_Void_NetworkWriter_SpawnMessage_0;

		// Token: 0x04003863 RID: 14435
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_SpawnFlags_Public_Static_Void_NetworkWriter_SpawnFlags_0;

		// Token: 0x04003864 RID: 14436
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_ChangeOwnerMessage_Public_Static_ChangeOwnerMessage_NetworkReader_0;

		// Token: 0x04003865 RID: 14437
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_ChangeOwnerMessage_Public_Static_Void_NetworkWriter_ChangeOwnerMessage_0;

		// Token: 0x04003866 RID: 14438
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_ObjectSpawnStartedMessage_Public_Static_ObjectSpawnStartedMessage_NetworkReader_0;

		// Token: 0x04003867 RID: 14439
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_ObjectSpawnStartedMessage_Public_Static_Void_NetworkWriter_ObjectSpawnStartedMessage_0;

		// Token: 0x04003868 RID: 14440
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_ObjectSpawnFinishedMessage_Public_Static_ObjectSpawnFinishedMessage_NetworkReader_0;

		// Token: 0x04003869 RID: 14441
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_ObjectSpawnFinishedMessage_Public_Static_Void_NetworkWriter_ObjectSpawnFinishedMessage_0;

		// Token: 0x0400386A RID: 14442
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_ObjectDestroyMessage_Public_Static_ObjectDestroyMessage_NetworkReader_0;

		// Token: 0x0400386B RID: 14443
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_ObjectDestroyMessage_Public_Static_Void_NetworkWriter_ObjectDestroyMessage_0;

		// Token: 0x0400386C RID: 14444
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_ObjectHideMessage_Public_Static_ObjectHideMessage_NetworkReader_0;

		// Token: 0x0400386D RID: 14445
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_ObjectHideMessage_Public_Static_Void_NetworkWriter_ObjectHideMessage_0;

		// Token: 0x0400386E RID: 14446
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_EntityStateMessage_Public_Static_EntityStateMessage_NetworkReader_0;

		// Token: 0x0400386F RID: 14447
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_EntityStateMessage_Public_Static_Void_NetworkWriter_EntityStateMessage_0;

		// Token: 0x04003870 RID: 14448
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_NetworkPingMessage_Public_Static_NetworkPingMessage_NetworkReader_0;

		// Token: 0x04003871 RID: 14449
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_NetworkPingMessage_Public_Static_Void_NetworkWriter_NetworkPingMessage_0;

		// Token: 0x04003872 RID: 14450
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_NetworkPongMessage_Public_Static_NetworkPongMessage_NetworkReader_0;

		// Token: 0x04003873 RID: 14451
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_NetworkPongMessage_Public_Static_Void_NetworkWriter_NetworkPongMessage_0;

		// Token: 0x04003874 RID: 14452
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_Discovery_ServerRequest_Public_Static_ServerRequest_NetworkReader_0;

		// Token: 0x04003875 RID: 14453
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_Discovery_ServerRequest_Public_Static_Void_NetworkWriter_ServerRequest_0;

		// Token: 0x04003876 RID: 14454
		private static readonly IntPtr NativeMethodInfoPtr__Read_Mirror_Discovery_ServerResponse_Public_Static_ServerResponse_NetworkReader_0;

		// Token: 0x04003877 RID: 14455
		private static readonly IntPtr NativeMethodInfoPtr__Write_Mirror_Discovery_ServerResponse_Public_Static_Void_NetworkWriter_ServerResponse_0;

		// Token: 0x04003878 RID: 14456
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_AuthRequestMessage_NetworkReader_PDM_0;

		// Token: 0x04003879 RID: 14457
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_NetworkWriter_AuthRequestMessage_PDM_0;

		// Token: 0x0400387A RID: 14458
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_AuthResponseMessage_NetworkReader_PDM_0;

		// Token: 0x0400387B RID: 14459
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_NetworkWriter_AuthResponseMessage_PDM_0;

		// Token: 0x0400387C RID: 14460
		private static readonly IntPtr NativeMethodInfoPtr__Write_Polytoria_Datamodel_PartShape_Public_Static_Void_NetworkWriter_PartShape_0;

		// Token: 0x0400387D RID: 14461
		private static readonly IntPtr NativeMethodInfoPtr__Read_Polytoria_Datamodel_PartShape_Public_Static_PartShape_NetworkReader_0;

		// Token: 0x0400387E RID: 14462
		private static readonly IntPtr NativeMethodInfoPtr__Write_Polytoria_Datamodel_PartMaterial_Public_Static_Void_NetworkWriter_PartMaterial_0;

		// Token: 0x0400387F RID: 14463
		private static readonly IntPtr NativeMethodInfoPtr__Read_Polytoria_Datamodel_PartMaterial_Public_Static_PartMaterial_NetworkReader_0;

		// Token: 0x04003880 RID: 14464
		private static readonly IntPtr NativeMethodInfoPtr__Write_UnityEngine_PhysicsMaterialCombine_Public_Static_Void_NetworkWriter_PhysicsMaterialCombine_0;

		// Token: 0x04003881 RID: 14465
		private static readonly IntPtr NativeMethodInfoPtr__Read_UnityEngine_PhysicsMaterialCombine_Public_Static_PhysicsMaterialCombine_NetworkReader_0;

		// Token: 0x04003882 RID: 14466
		private static readonly IntPtr NativeMethodInfoPtr__Write_Polytoria_Controllers_ImageType_Public_Static_Void_NetworkWriter_ImageType_0;

		// Token: 0x04003883 RID: 14467
		private static readonly IntPtr NativeMethodInfoPtr__Read_Polytoria_Controllers_ImageType_Public_Static_ImageType_NetworkReader_0;

		// Token: 0x04003884 RID: 14468
		private static readonly IntPtr NativeMethodInfoPtr__Write_Polytoria_Datamodel_SkyboxPreset_Public_Static_Void_NetworkWriter_SkyboxPreset_0;

		// Token: 0x04003885 RID: 14469
		private static readonly IntPtr NativeMethodInfoPtr__Read_Polytoria_Datamodel_SkyboxPreset_Public_Static_SkyboxPreset_NetworkReader_0;

		// Token: 0x04003886 RID: 14470
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_NetworkWriter_SkyboxSide_0;

		// Token: 0x04003887 RID: 14471
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_SkyboxSide_NetworkReader_0;

		// Token: 0x04003888 RID: 14472
		private static readonly IntPtr NativeMethodInfoPtr__Write_Polytoria_Datamodel_AmbientSource_Public_Static_Void_NetworkWriter_AmbientSource_0;

		// Token: 0x04003889 RID: 14473
		private static readonly IntPtr NativeMethodInfoPtr__Read_Polytoria_Datamodel_AmbientSource_Public_Static_AmbientSource_NetworkReader_0;

		// Token: 0x0400388A RID: 14474
		private static readonly IntPtr NativeMethodInfoPtr__Write_Polytoria_Datamodel_CollisionType_Public_Static_Void_NetworkWriter_CollisionType_0;

		// Token: 0x0400388B RID: 14475
		private static readonly IntPtr NativeMethodInfoPtr__Read_Polytoria_Datamodel_CollisionType_Public_Static_CollisionType_NetworkReader_0;

		// Token: 0x0400388C RID: 14476
		private static readonly IntPtr NativeMethodInfoPtr__Write_Polytoria_Types_ColorRange_Public_Static_Void_NetworkWriter_ColorRange_0;

		// Token: 0x0400388D RID: 14477
		private static readonly IntPtr NativeMethodInfoPtr__Write_Polytoria_Datamodel_ParticleColorMode_Public_Static_Void_NetworkWriter_ParticleColorMode_0;

		// Token: 0x0400388E RID: 14478
		private static readonly IntPtr NativeMethodInfoPtr__Write_Polytoria_Types_NumberRange_Public_Static_Void_NetworkWriter_NumberRange_0;

		// Token: 0x0400388F RID: 14479
		private static readonly IntPtr NativeMethodInfoPtr__Write_Polytoria_Datamodel_ParticleSimulationSpace_Public_Static_Void_NetworkWriter_ParticleSimulationSpace_0;

		// Token: 0x04003890 RID: 14480
		private static readonly IntPtr NativeMethodInfoPtr__Write_Polytoria_Datamodel_ParticleShape_Public_Static_Void_NetworkWriter_ParticleShape_0;

		// Token: 0x04003891 RID: 14481
		private static readonly IntPtr NativeMethodInfoPtr__Read_Polytoria_Types_ColorRange_Public_Static_ColorRange_NetworkReader_0;

		// Token: 0x04003892 RID: 14482
		private static readonly IntPtr NativeMethodInfoPtr__Read_Polytoria_Datamodel_ParticleColorMode_Public_Static_ParticleColorMode_NetworkReader_0;

		// Token: 0x04003893 RID: 14483
		private static readonly IntPtr NativeMethodInfoPtr__Read_Polytoria_Types_NumberRange_Public_Static_NumberRange_NetworkReader_0;

		// Token: 0x04003894 RID: 14484
		private static readonly IntPtr NativeMethodInfoPtr__Read_Polytoria_Datamodel_ParticleSimulationSpace_Public_Static_ParticleSimulationSpace_NetworkReader_0;

		// Token: 0x04003895 RID: 14485
		private static readonly IntPtr NativeMethodInfoPtr__Read_Polytoria_Datamodel_ParticleShape_Public_Static_ParticleShape_NetworkReader_0;

		// Token: 0x04003896 RID: 14486
		private static readonly IntPtr NativeMethodInfoPtr__Write_Polytoria_Datamodel_BodyPart_Public_Static_Void_NetworkWriter_BodyPart_0;

		// Token: 0x04003897 RID: 14487
		private static readonly IntPtr NativeMethodInfoPtr__Read_Polytoria_Datamodel_BodyPart_Public_Static_BodyPart_NetworkReader_0;

		// Token: 0x04003898 RID: 14488
		private static readonly IntPtr NativeMethodInfoPtr__Write_TMPro_HorizontalAlignmentOptions_Public_Static_Void_NetworkWriter_HorizontalAlignmentOptions_0;

		// Token: 0x04003899 RID: 14489
		private static readonly IntPtr NativeMethodInfoPtr__Read_TMPro_HorizontalAlignmentOptions_Public_Static_HorizontalAlignmentOptions_NetworkReader_0;

		// Token: 0x0400389A RID: 14490
		private static readonly IntPtr NativeMethodInfoPtr__Write_TMPro_VerticalAlignmentOptions_Public_Static_Void_NetworkWriter_VerticalAlignmentOptions_0;

		// Token: 0x0400389B RID: 14491
		private static readonly IntPtr NativeMethodInfoPtr__Read_TMPro_VerticalAlignmentOptions_Public_Static_VerticalAlignmentOptions_NetworkReader_0;

		// Token: 0x0400389C RID: 14492
		private static readonly IntPtr NativeMethodInfoPtr__Write_Polytoria_Datamodel_TextFontPreset_Public_Static_Void_NetworkWriter_TextFontPreset_0;

		// Token: 0x0400389D RID: 14493
		private static readonly IntPtr NativeMethodInfoPtr__Read_Polytoria_Datamodel_TextFontPreset_Public_Static_TextFontPreset_NetworkReader_0;

		// Token: 0x0400389E RID: 14494
		private static readonly IntPtr NativeMethodInfoPtr__Write_Polytoria_Datamodel_TextJustify_Public_Static_Void_NetworkWriter_TextJustify_0;

		// Token: 0x0400389F RID: 14495
		private static readonly IntPtr NativeMethodInfoPtr__Write_Polytoria_Datamodel_TextVerticalAlign_Public_Static_Void_NetworkWriter_TextVerticalAlign_0;

		// Token: 0x040038A0 RID: 14496
		private static readonly IntPtr NativeMethodInfoPtr__Read_Polytoria_Datamodel_TextJustify_Public_Static_TextJustify_NetworkReader_0;

		// Token: 0x040038A1 RID: 14497
		private static readonly IntPtr NativeMethodInfoPtr__Read_Polytoria_Datamodel_TextVerticalAlign_Public_Static_TextVerticalAlign_NetworkReader_0;

		// Token: 0x040038A2 RID: 14498
		private static readonly IntPtr NativeMethodInfoPtr__Write_UnityEngine_TextAnchor_Public_Static_Void_NetworkWriter_TextAnchor_0;

		// Token: 0x040038A3 RID: 14499
		private static readonly IntPtr NativeMethodInfoPtr__Read_UnityEngine_TextAnchor_Public_Static_TextAnchor_NetworkReader_0;

		// Token: 0x040038A4 RID: 14500
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_NetworkWriter_Il2CppStringArray_0;

		// Token: 0x040038A5 RID: 14501
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppStringArray_NetworkReader_PDM_0;

		// Token: 0x040038A6 RID: 14502
		private static readonly IntPtr NativeMethodInfoPtr_InitReadWriters_Public_Static_Void_0;
	}
}
