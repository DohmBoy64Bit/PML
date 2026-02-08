using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Xml;
using Polytoria.Datamodel;
using Polytoria.Types;
using U8Xml;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Controllers
{
	// Token: 0x02000327 RID: 807
	public class GameIO : MonoBehaviour
	{
		// Token: 0x0600454D RID: 17741 RVA: 0x00135D54 File Offset: 0x00133F54
		// Note: this type is marked as 'beforefieldinit'.
		static GameIO()
		{
			Il2CppClassPointerStore<GameIO>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "GameIO");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameIO>.NativeClassPtr);
			GameIO.NativeFieldInfoPtr_game = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO>.NativeClassPtr, "game");
			GameIO.NativeFieldInfoPtr_singleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO>.NativeClassPtr, "singleton");
			GameIO.NativeFieldInfoPtr_spawnInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO>.NativeClassPtr, "spawnInstances");
			GameIO.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674300);
			GameIO.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674268);
			GameIO.NativeMethodInfoPtr_Load_Public_Void_Int32_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674269);
			GameIO.NativeMethodInfoPtr_LoadFromFile_Public_Void_String_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674270);
			GameIO.NativeMethodInfoPtr_LoadModelFromFile_Public_Instance_String_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674271);
			GameIO.NativeMethodInfoPtr_LoadModelFromSite_Public_Void_Int32_Instance_Action_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674272);
			GameIO.NativeMethodInfoPtr_LoadModelFromXmlString_Public_Model_String_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674273);
			GameIO.NativeMethodInfoPtr_ClearDatamodel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674274);
			GameIO.NativeMethodInfoPtr_PostClearDatamodel_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674275);
			GameIO.NativeMethodInfoPtr_PostMapLoad_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674276);
			GameIO.NativeMethodInfoPtr_ModelFromSite_Public_IEnumerator_Int32_Instance_Action_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674277);
			GameIO.NativeMethodInfoPtr_LoadFromSite_Public_IEnumerator_Int32_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674278);
			GameIO.NativeMethodInfoPtr_LoadXml_Private_Instance_XmlNode_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674279);
			GameIO.NativeMethodInfoPtr_HandleXmlNodes_Private_Instance_XmlNodeList_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674280);
			GameIO.NativeMethodInfoPtr_XmlConvertVector3_Public_Vector3_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674281);
			GameIO.NativeMethodInfoPtr_XmlConvertVector2_Public_Vector2_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674282);
			GameIO.NativeMethodInfoPtr_XmlConvertColor_Public_Color_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674283);
			GameIO.NativeMethodInfoPtr_XmlConvertColorRange_Public_ColorRange_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674284);
			GameIO.NativeMethodInfoPtr_XmlConvertNumberRange_Public_NumberRange_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674285);
			GameIO.NativeMethodInfoPtr_SaveModelToString_Public_String_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674286);
			GameIO.NativeMethodInfoPtr_SaveModelToFile_Public_Void_Instance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674287);
			GameIO.NativeMethodInfoPtr_SaveToString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674288);
			GameIO.NativeMethodInfoPtr_SaveToFile_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674289);
			GameIO.NativeMethodInfoPtr_SaveHandleChild_Private_Void_XmlDocument_Instance_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674290);
			GameIO.NativeMethodInfoPtr_SaveString_Private_Void_XmlDocument_XmlElement_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674291);
			GameIO.NativeMethodInfoPtr_SaveFloat_Private_Void_XmlDocument_XmlElement_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674292);
			GameIO.NativeMethodInfoPtr_SaveInt_Private_Void_XmlDocument_XmlElement_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674293);
			GameIO.NativeMethodInfoPtr_SaveBool_Private_Void_XmlDocument_XmlElement_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674294);
			GameIO.NativeMethodInfoPtr_SaveVector3_Private_Void_XmlDocument_XmlElement_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674295);
			GameIO.NativeMethodInfoPtr_SaveVector2_Private_Void_XmlDocument_XmlElement_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674296);
			GameIO.NativeMethodInfoPtr_SaveColor_Private_Void_XmlDocument_XmlElement_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674297);
			GameIO.NativeMethodInfoPtr_SaveColorRange_Private_Void_XmlDocument_XmlElement_String_ColorRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674298);
			GameIO.NativeMethodInfoPtr_SaveNumberRange_Private_Void_XmlDocument_XmlElement_String_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO>.NativeClassPtr, 100674299);
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x00136054 File Offset: 0x00134254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132385, XrefRangeEnd = 132393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameIO()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameIO>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x00136090 File Offset: 0x00134290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132393, XrefRangeEnd = 132401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x001360C4 File Offset: 0x001342C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 132417, RefRangeEnd = 132420, XrefRangeStart = 132401, XrefRangeEnd = 132417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(int id, Action<bool> callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_Load_Public_Void_Int32_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x00136114 File Offset: 0x00134314
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132437, RefRangeEnd = 132439, XrefRangeStart = 132420, XrefRangeEnd = 132437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadFromFile(string path, Action<bool> callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_LoadFromFile_Public_Void_String_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x00136168 File Offset: 0x00134368
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132448, RefRangeEnd = 132449, XrefRangeStart = 132439, XrefRangeEnd = 132448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instance LoadModelFromFile(string path, Instance parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_LoadModelFromFile_Public_Instance_String_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x001361CC File Offset: 0x001343CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132457, RefRangeEnd = 132459, XrefRangeStart = 132449, XrefRangeEnd = 132457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadModelFromSite(int id, Instance parent, Action<Instance> callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_LoadModelFromSite_Public_Void_Int32_Instance_Action_1_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x00136230 File Offset: 0x00134430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132475, RefRangeEnd = 132476, XrefRangeStart = 132459, XrefRangeEnd = 132475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Model LoadModelFromXmlString(string xmlString, Instance parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_LoadModelFromXmlString_Public_Model_String_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Model>(intPtr3) : null;
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x00136294 File Offset: 0x00134494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132491, RefRangeEnd = 132492, XrefRangeStart = 132476, XrefRangeEnd = 132491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearDatamodel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_ClearDatamodel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x001362C8 File Offset: 0x001344C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132492, XrefRangeEnd = 132497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PostClearDatamodel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_PostClearDatamodel_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x00136308 File Offset: 0x00134508
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132715, RefRangeEnd = 132717, XrefRangeStart = 132497, XrefRangeEnd = 132715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PostMapLoad()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_PostMapLoad_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x0013633C File Offset: 0x0013453C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132717, XrefRangeEnd = 132724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ModelFromSite(int id, Instance parent, Action<Instance> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_ModelFromSite_Public_IEnumerator_Int32_Instance_Action_1_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x001363AC File Offset: 0x001345AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132724, XrefRangeEnd = 132730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadFromSite(int id, Action<bool> callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_LoadFromSite_Public_IEnumerator_Int32_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x0013640C File Offset: 0x0013460C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 132740, RefRangeEnd = 132745, XrefRangeStart = 132730, XrefRangeEnd = 132740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instance LoadXml(global::U8Xml.XmlNode xml, Instance parent = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xml);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_LoadXml_Private_Instance_XmlNode_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x00136470 File Offset: 0x00134670
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133833, RefRangeEnd = 133835, XrefRangeStart = 132745, XrefRangeEnd = 133833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instance HandleXmlNodes(global::U8Xml.XmlNodeList nodes, Instance parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_HandleXmlNodes_Private_Instance_XmlNodeList_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
		}

		// Token: 0x0600455C RID: 17756 RVA: 0x001364D4 File Offset: 0x001346D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 133850, RefRangeEnd = 133851, XrefRangeStart = 133835, XrefRangeEnd = 133850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 XmlConvertVector3(global::U8Xml.XmlNode property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_XmlConvertVector3_Public_Vector3_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x0600455D RID: 17757 RVA: 0x00136524 File Offset: 0x00134724
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 133861, RefRangeEnd = 133862, XrefRangeStart = 133851, XrefRangeEnd = 133861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 XmlConvertVector2(global::U8Xml.XmlNode property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_XmlConvertVector2_Public_Vector2_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x00136574 File Offset: 0x00134774
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 133890, RefRangeEnd = 133894, XrefRangeStart = 133862, XrefRangeEnd = 133890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color XmlConvertColor(global::U8Xml.XmlNode property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_XmlConvertColor_Public_Color_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x001365C4 File Offset: 0x001347C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 133908, RefRangeEnd = 133909, XrefRangeStart = 133894, XrefRangeEnd = 133908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorRange XmlConvertColorRange(global::U8Xml.XmlNode property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_XmlConvertColorRange_Public_ColorRange_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColorRange>(intPtr3) : null;
			}
		}

		// Token: 0x06004560 RID: 17760 RVA: 0x00136614 File Offset: 0x00134814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 133925, RefRangeEnd = 133926, XrefRangeStart = 133909, XrefRangeEnd = 133925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberRange XmlConvertNumberRange(global::U8Xml.XmlNode property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_XmlConvertNumberRange_Public_NumberRange_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr3) : null;
			}
		}

		// Token: 0x06004561 RID: 17761 RVA: 0x00136664 File Offset: 0x00134864
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133954, RefRangeEnd = 133956, XrefRangeStart = 133926, XrefRangeEnd = 133954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SaveModelToString(Instance root)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_SaveModelToString_Public_String_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x001366AC File Offset: 0x001348AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 133970, RefRangeEnd = 133971, XrefRangeStart = 133956, XrefRangeEnd = 133970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveModelToFile(Instance root, string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_SaveModelToFile_Public_Void_Instance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x00136700 File Offset: 0x00134900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134001, RefRangeEnd = 134002, XrefRangeStart = 133971, XrefRangeEnd = 134001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SaveToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_SaveToString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004564 RID: 17764 RVA: 0x00136738 File Offset: 0x00134938
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 134025, RefRangeEnd = 134028, XrefRangeStart = 134002, XrefRangeEnd = 134025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveToFile(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_SaveToFile_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x0013677C File Offset: 0x0013497C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 134176, RefRangeEnd = 134181, XrefRangeStart = 134028, XrefRangeEnd = 134176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveHandleChild(XmlDocument doc, Instance i, XmlElement parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(i);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_SaveHandleChild_Private_Void_XmlDocument_Instance_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004566 RID: 17766 RVA: 0x001367E4 File Offset: 0x001349E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134189, RefRangeEnd = 134190, XrefRangeStart = 134181, XrefRangeEnd = 134189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveString(XmlDocument doc, XmlElement properties, string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_SaveString_Private_Void_XmlDocument_XmlElement_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x00136860 File Offset: 0x00134A60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 134204, RefRangeEnd = 134207, XrefRangeStart = 134190, XrefRangeEnd = 134204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveFloat(XmlDocument doc, XmlElement properties, string name, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_SaveFloat_Private_Void_XmlDocument_XmlElement_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004568 RID: 17768 RVA: 0x001368D4 File Offset: 0x00134AD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134215, RefRangeEnd = 134216, XrefRangeStart = 134207, XrefRangeEnd = 134215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveInt(XmlDocument doc, XmlElement properties, string name, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_SaveInt_Private_Void_XmlDocument_XmlElement_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004569 RID: 17769 RVA: 0x00136948 File Offset: 0x00134B48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134228, RefRangeEnd = 134229, XrefRangeStart = 134216, XrefRangeEnd = 134228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveBool(XmlDocument doc, XmlElement properties, string name, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_SaveBool_Private_Void_XmlDocument_XmlElement_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600456A RID: 17770 RVA: 0x001369BC File Offset: 0x00134BBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134258, RefRangeEnd = 134259, XrefRangeStart = 134229, XrefRangeEnd = 134258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveVector3(XmlDocument doc, XmlElement properties, string name, Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_SaveVector3_Private_Void_XmlDocument_XmlElement_String_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x00136A38 File Offset: 0x00134C38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134282, RefRangeEnd = 134283, XrefRangeStart = 134259, XrefRangeEnd = 134282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveVector2(XmlDocument doc, XmlElement properties, string name, Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_SaveVector2_Private_Void_XmlDocument_XmlElement_String_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600456C RID: 17772 RVA: 0x00136AB4 File Offset: 0x00134CB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 134318, RefRangeEnd = 134321, XrefRangeStart = 134283, XrefRangeEnd = 134318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveColor(XmlDocument doc, XmlElement properties, string name, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_SaveColor_Private_Void_XmlDocument_XmlElement_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600456D RID: 17773 RVA: 0x00136B30 File Offset: 0x00134D30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134339, RefRangeEnd = 134340, XrefRangeStart = 134321, XrefRangeEnd = 134339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveColorRange(XmlDocument doc, XmlElement properties, string name, ColorRange value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_SaveColorRange_Private_Void_XmlDocument_XmlElement_String_ColorRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x00136BAC File Offset: 0x00134DAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134358, RefRangeEnd = 134359, XrefRangeStart = 134340, XrefRangeEnd = 134358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveNumberRange(XmlDocument doc, XmlElement properties, string name, NumberRange value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.NativeMethodInfoPtr_SaveNumberRange_Private_Void_XmlDocument_XmlElement_String_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600456F RID: 17775 RVA: 0x0001993F File Offset: 0x00017B3F
		public GameIO(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x06004570 RID: 17776 RVA: 0x00136C28 File Offset: 0x00134E28
		// (set) Token: 0x06004571 RID: 17777 RVA: 0x00019948 File Offset: 0x00017B48
		public unsafe Game game
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO.NativeFieldInfoPtr_game);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Game>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO.NativeFieldInfoPtr_game), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x06004572 RID: 17778 RVA: 0x00136C58 File Offset: 0x00134E58
		// (set) Token: 0x06004573 RID: 17779 RVA: 0x00019967 File Offset: 0x00017B67
		public unsafe static GameIO singleton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GameIO.NativeFieldInfoPtr_singleton, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameIO>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameIO.NativeFieldInfoPtr_singleton, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x06004574 RID: 17780 RVA: 0x00136C80 File Offset: 0x00134E80
		// (set) Token: 0x06004575 RID: 17781 RVA: 0x00019979 File Offset: 0x00017B79
		public unsafe List<Instance> spawnInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO.NativeFieldInfoPtr_spawnInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Instance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO.NativeFieldInfoPtr_spawnInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040035D9 RID: 13785
		private static readonly IntPtr NativeFieldInfoPtr_game;

		// Token: 0x040035DA RID: 13786
		private static readonly IntPtr NativeFieldInfoPtr_singleton;

		// Token: 0x040035DB RID: 13787
		private static readonly IntPtr NativeFieldInfoPtr_spawnInstances;

		// Token: 0x040035DC RID: 13788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040035DD RID: 13789
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040035DE RID: 13790
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_Int32_Action_1_Boolean_0;

		// Token: 0x040035DF RID: 13791
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromFile_Public_Void_String_Action_1_Boolean_0;

		// Token: 0x040035E0 RID: 13792
		private static readonly IntPtr NativeMethodInfoPtr_LoadModelFromFile_Public_Instance_String_Instance_0;

		// Token: 0x040035E1 RID: 13793
		private static readonly IntPtr NativeMethodInfoPtr_LoadModelFromSite_Public_Void_Int32_Instance_Action_1_Instance_0;

		// Token: 0x040035E2 RID: 13794
		private static readonly IntPtr NativeMethodInfoPtr_LoadModelFromXmlString_Public_Model_String_Instance_0;

		// Token: 0x040035E3 RID: 13795
		private static readonly IntPtr NativeMethodInfoPtr_ClearDatamodel_Public_Void_0;

		// Token: 0x040035E4 RID: 13796
		private static readonly IntPtr NativeMethodInfoPtr_PostClearDatamodel_Private_IEnumerator_0;

		// Token: 0x040035E5 RID: 13797
		private static readonly IntPtr NativeMethodInfoPtr_PostMapLoad_Public_Void_0;

		// Token: 0x040035E6 RID: 13798
		private static readonly IntPtr NativeMethodInfoPtr_ModelFromSite_Public_IEnumerator_Int32_Instance_Action_1_Instance_0;

		// Token: 0x040035E7 RID: 13799
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromSite_Public_IEnumerator_Int32_Action_1_Boolean_0;

		// Token: 0x040035E8 RID: 13800
		private static readonly IntPtr NativeMethodInfoPtr_LoadXml_Private_Instance_XmlNode_Instance_0;

		// Token: 0x040035E9 RID: 13801
		private static readonly IntPtr NativeMethodInfoPtr_HandleXmlNodes_Private_Instance_XmlNodeList_Instance_0;

		// Token: 0x040035EA RID: 13802
		private static readonly IntPtr NativeMethodInfoPtr_XmlConvertVector3_Public_Vector3_XmlNode_0;

		// Token: 0x040035EB RID: 13803
		private static readonly IntPtr NativeMethodInfoPtr_XmlConvertVector2_Public_Vector2_XmlNode_0;

		// Token: 0x040035EC RID: 13804
		private static readonly IntPtr NativeMethodInfoPtr_XmlConvertColor_Public_Color_XmlNode_0;

		// Token: 0x040035ED RID: 13805
		private static readonly IntPtr NativeMethodInfoPtr_XmlConvertColorRange_Public_ColorRange_XmlNode_0;

		// Token: 0x040035EE RID: 13806
		private static readonly IntPtr NativeMethodInfoPtr_XmlConvertNumberRange_Public_NumberRange_XmlNode_0;

		// Token: 0x040035EF RID: 13807
		private static readonly IntPtr NativeMethodInfoPtr_SaveModelToString_Public_String_Instance_0;

		// Token: 0x040035F0 RID: 13808
		private static readonly IntPtr NativeMethodInfoPtr_SaveModelToFile_Public_Void_Instance_String_0;

		// Token: 0x040035F1 RID: 13809
		private static readonly IntPtr NativeMethodInfoPtr_SaveToString_Public_String_0;

		// Token: 0x040035F2 RID: 13810
		private static readonly IntPtr NativeMethodInfoPtr_SaveToFile_Public_Void_String_0;

		// Token: 0x040035F3 RID: 13811
		private static readonly IntPtr NativeMethodInfoPtr_SaveHandleChild_Private_Void_XmlDocument_Instance_XmlElement_0;

		// Token: 0x040035F4 RID: 13812
		private static readonly IntPtr NativeMethodInfoPtr_SaveString_Private_Void_XmlDocument_XmlElement_String_String_0;

		// Token: 0x040035F5 RID: 13813
		private static readonly IntPtr NativeMethodInfoPtr_SaveFloat_Private_Void_XmlDocument_XmlElement_String_Single_0;

		// Token: 0x040035F6 RID: 13814
		private static readonly IntPtr NativeMethodInfoPtr_SaveInt_Private_Void_XmlDocument_XmlElement_String_Int32_0;

		// Token: 0x040035F7 RID: 13815
		private static readonly IntPtr NativeMethodInfoPtr_SaveBool_Private_Void_XmlDocument_XmlElement_String_Boolean_0;

		// Token: 0x040035F8 RID: 13816
		private static readonly IntPtr NativeMethodInfoPtr_SaveVector3_Private_Void_XmlDocument_XmlElement_String_Vector3_0;

		// Token: 0x040035F9 RID: 13817
		private static readonly IntPtr NativeMethodInfoPtr_SaveVector2_Private_Void_XmlDocument_XmlElement_String_Vector2_0;

		// Token: 0x040035FA RID: 13818
		private static readonly IntPtr NativeMethodInfoPtr_SaveColor_Private_Void_XmlDocument_XmlElement_String_Color_0;

		// Token: 0x040035FB RID: 13819
		private static readonly IntPtr NativeMethodInfoPtr_SaveColorRange_Private_Void_XmlDocument_XmlElement_String_ColorRange_0;

		// Token: 0x040035FC RID: 13820
		private static readonly IntPtr NativeMethodInfoPtr_SaveNumberRange_Private_Void_XmlDocument_XmlElement_String_NumberRange_0;

		// Token: 0x02000428 RID: 1064
		[ObfuscatedName("Polytoria.Controllers.GameIO+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060051B2 RID: 20914 RVA: 0x0015CEC0 File Offset: 0x0015B0C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GameIO.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameIO>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameIO.__c>.NativeClassPtr);
				GameIO.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO.__c>.NativeClassPtr, "<>9");
				GameIO.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO.__c>.NativeClassPtr, "<>9__25_0");
				GameIO.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO.__c>.NativeClassPtr, 100674302);
				GameIO.__c.NativeMethodInfoPtr__SaveHandleChild_b__25_0_Internal_Boolean_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO.__c>.NativeClassPtr, 100674303);
			}

			// Token: 0x060051B3 RID: 20915 RVA: 0x0015CF3C File Offset: 0x0015B13C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameIO.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051B4 RID: 20916 RVA: 0x0015CF78 File Offset: 0x0015B178
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132228, XrefRangeEnd = 132234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SaveHandleChild_b__25_0(PropertyInfo prop)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO.__c.NativeMethodInfoPtr__SaveHandleChild_b__25_0_Internal_Boolean_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051B5 RID: 20917 RVA: 0x0001F728 File Offset: 0x0001D928
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B8E RID: 7054
			// (get) Token: 0x060051B6 RID: 20918 RVA: 0x0015CFC8 File Offset: 0x0015B1C8
			// (set) Token: 0x060051B7 RID: 20919 RVA: 0x0001F731 File Offset: 0x0001D931
			public unsafe static GameIO.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameIO.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameIO.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameIO.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B8F RID: 7055
			// (get) Token: 0x060051B8 RID: 20920 RVA: 0x0015CFF0 File Offset: 0x0015B1F0
			// (set) Token: 0x060051B9 RID: 20921 RVA: 0x0001F743 File Offset: 0x0001D943
			public unsafe static Func<PropertyInfo, bool> __9__25_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameIO.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PropertyInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameIO.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003EB3 RID: 16051
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003EB4 RID: 16052
			private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

			// Token: 0x04003EB5 RID: 16053
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003EB6 RID: 16054
			private static readonly IntPtr NativeMethodInfoPtr__SaveHandleChild_b__25_0_Internal_Boolean_PropertyInfo_0;
		}

		// Token: 0x02000429 RID: 1065
		[ObfuscatedName("Polytoria.Controllers.GameIO+<LoadFromSite>d__13")]
		public sealed class _LoadFromSite_d__13 : global::Il2CppSystem.Object
		{
			// Token: 0x060051BA RID: 20922 RVA: 0x0015D018 File Offset: 0x0015B218
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadFromSite_d__13()
			{
				Il2CppClassPointerStore<GameIO._LoadFromSite_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameIO>.NativeClassPtr, "<LoadFromSite>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameIO._LoadFromSite_d__13>.NativeClassPtr);
				GameIO._LoadFromSite_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO._LoadFromSite_d__13>.NativeClassPtr, "<>1__state");
				GameIO._LoadFromSite_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO._LoadFromSite_d__13>.NativeClassPtr, "<>2__current");
				GameIO._LoadFromSite_d__13.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO._LoadFromSite_d__13>.NativeClassPtr, "id");
				GameIO._LoadFromSite_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO._LoadFromSite_d__13>.NativeClassPtr, "<>4__this");
				GameIO._LoadFromSite_d__13.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO._LoadFromSite_d__13>.NativeClassPtr, "callback");
				GameIO._LoadFromSite_d__13.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO._LoadFromSite_d__13>.NativeClassPtr, "<uwr>5__2");
				GameIO._LoadFromSite_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._LoadFromSite_d__13>.NativeClassPtr, 100674308);
				GameIO._LoadFromSite_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._LoadFromSite_d__13>.NativeClassPtr, 100674310);
				GameIO._LoadFromSite_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._LoadFromSite_d__13>.NativeClassPtr, 100674304);
				GameIO._LoadFromSite_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._LoadFromSite_d__13>.NativeClassPtr, 100674305);
				GameIO._LoadFromSite_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._LoadFromSite_d__13>.NativeClassPtr, 100674306);
				GameIO._LoadFromSite_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._LoadFromSite_d__13>.NativeClassPtr, 100674307);
				GameIO._LoadFromSite_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._LoadFromSite_d__13>.NativeClassPtr, 100674309);
			}

			// Token: 0x17001B96 RID: 7062
			// (get) Token: 0x060051BB RID: 20923 RVA: 0x0015D148 File Offset: 0x0015B348
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._LoadFromSite_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001B97 RID: 7063
			// (get) Token: 0x060051BC RID: 20924 RVA: 0x0015D188 File Offset: 0x0015B388
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._LoadFromSite_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060051BD RID: 20925 RVA: 0x0015D1C8 File Offset: 0x0015B3C8
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadFromSite_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameIO._LoadFromSite_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._LoadFromSite_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051BE RID: 20926 RVA: 0x0015D210 File Offset: 0x0015B410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132234, XrefRangeEnd = 132239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._LoadFromSite_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051BF RID: 20927 RVA: 0x0015D244 File Offset: 0x0015B444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132239, XrefRangeEnd = 132306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._LoadFromSite_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051C0 RID: 20928 RVA: 0x0015D280 File Offset: 0x0015B480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132306, XrefRangeEnd = 132309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._LoadFromSite_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051C1 RID: 20929 RVA: 0x0015D2B4 File Offset: 0x0015B4B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132309, XrefRangeEnd = 132314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._LoadFromSite_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051C2 RID: 20930 RVA: 0x0001F755 File Offset: 0x0001D955
			public _LoadFromSite_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B90 RID: 7056
			// (get) Token: 0x060051C3 RID: 20931 RVA: 0x0015D2E8 File Offset: 0x0015B4E8
			// (set) Token: 0x060051C4 RID: 20932 RVA: 0x0001F75E File Offset: 0x0001D95E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._LoadFromSite_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._LoadFromSite_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B91 RID: 7057
			// (get) Token: 0x060051C5 RID: 20933 RVA: 0x0015D310 File Offset: 0x0015B510
			// (set) Token: 0x060051C6 RID: 20934 RVA: 0x0001F779 File Offset: 0x0001D979
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._LoadFromSite_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._LoadFromSite_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B92 RID: 7058
			// (get) Token: 0x060051C7 RID: 20935 RVA: 0x0015D340 File Offset: 0x0015B540
			// (set) Token: 0x060051C8 RID: 20936 RVA: 0x0001F798 File Offset: 0x0001D998
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._LoadFromSite_d__13.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._LoadFromSite_d__13.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x17001B93 RID: 7059
			// (get) Token: 0x060051C9 RID: 20937 RVA: 0x0015D368 File Offset: 0x0015B568
			// (set) Token: 0x060051CA RID: 20938 RVA: 0x0001F7B3 File Offset: 0x0001D9B3
			public unsafe GameIO __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._LoadFromSite_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameIO>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._LoadFromSite_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B94 RID: 7060
			// (get) Token: 0x060051CB RID: 20939 RVA: 0x0015D398 File Offset: 0x0015B598
			// (set) Token: 0x060051CC RID: 20940 RVA: 0x0001F7D2 File Offset: 0x0001D9D2
			public unsafe Action<bool> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._LoadFromSite_d__13.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._LoadFromSite_d__13.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B95 RID: 7061
			// (get) Token: 0x060051CD RID: 20941 RVA: 0x0015D3C8 File Offset: 0x0015B5C8
			// (set) Token: 0x060051CE RID: 20942 RVA: 0x0001F7F1 File Offset: 0x0001D9F1
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._LoadFromSite_d__13.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._LoadFromSite_d__13.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003EB7 RID: 16055
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003EB8 RID: 16056
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003EB9 RID: 16057
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04003EBA RID: 16058
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003EBB RID: 16059
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04003EBC RID: 16060
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003EBD RID: 16061
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003EBE RID: 16062
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003EBF RID: 16063
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003EC0 RID: 16064
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003EC1 RID: 16065
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003EC2 RID: 16066
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003EC3 RID: 16067
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x0200042A RID: 1066
		[ObfuscatedName("Polytoria.Controllers.GameIO+<ModelFromSite>d__12")]
		public sealed class _ModelFromSite_d__12 : global::Il2CppSystem.Object
		{
			// Token: 0x060051CF RID: 20943 RVA: 0x0015D3F8 File Offset: 0x0015B5F8
			// Note: this type is marked as 'beforefieldinit'.
			static _ModelFromSite_d__12()
			{
				Il2CppClassPointerStore<GameIO._ModelFromSite_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameIO>.NativeClassPtr, "<ModelFromSite>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameIO._ModelFromSite_d__12>.NativeClassPtr);
				GameIO._ModelFromSite_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO._ModelFromSite_d__12>.NativeClassPtr, "<>1__state");
				GameIO._ModelFromSite_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO._ModelFromSite_d__12>.NativeClassPtr, "<>2__current");
				GameIO._ModelFromSite_d__12.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO._ModelFromSite_d__12>.NativeClassPtr, "id");
				GameIO._ModelFromSite_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO._ModelFromSite_d__12>.NativeClassPtr, "<>4__this");
				GameIO._ModelFromSite_d__12.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO._ModelFromSite_d__12>.NativeClassPtr, "parent");
				GameIO._ModelFromSite_d__12.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO._ModelFromSite_d__12>.NativeClassPtr, "callback");
				GameIO._ModelFromSite_d__12.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO._ModelFromSite_d__12>.NativeClassPtr, "<uwr>5__2");
				GameIO._ModelFromSite_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._ModelFromSite_d__12>.NativeClassPtr, 100674315);
				GameIO._ModelFromSite_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._ModelFromSite_d__12>.NativeClassPtr, 100674317);
				GameIO._ModelFromSite_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._ModelFromSite_d__12>.NativeClassPtr, 100674311);
				GameIO._ModelFromSite_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._ModelFromSite_d__12>.NativeClassPtr, 100674312);
				GameIO._ModelFromSite_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._ModelFromSite_d__12>.NativeClassPtr, 100674313);
				GameIO._ModelFromSite_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._ModelFromSite_d__12>.NativeClassPtr, 100674314);
				GameIO._ModelFromSite_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._ModelFromSite_d__12>.NativeClassPtr, 100674316);
			}

			// Token: 0x17001B9F RID: 7071
			// (get) Token: 0x060051D0 RID: 20944 RVA: 0x0015D53C File Offset: 0x0015B73C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._ModelFromSite_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001BA0 RID: 7072
			// (get) Token: 0x060051D1 RID: 20945 RVA: 0x0015D57C File Offset: 0x0015B77C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._ModelFromSite_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060051D2 RID: 20946 RVA: 0x0015D5BC File Offset: 0x0015B7BC
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ModelFromSite_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameIO._ModelFromSite_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._ModelFromSite_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051D3 RID: 20947 RVA: 0x0015D604 File Offset: 0x0015B804
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132314, XrefRangeEnd = 132319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._ModelFromSite_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051D4 RID: 20948 RVA: 0x0015D638 File Offset: 0x0015B838
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132319, XrefRangeEnd = 132367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._ModelFromSite_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051D5 RID: 20949 RVA: 0x0015D674 File Offset: 0x0015B874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132367, XrefRangeEnd = 132370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._ModelFromSite_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051D6 RID: 20950 RVA: 0x0015D6A8 File Offset: 0x0015B8A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132370, XrefRangeEnd = 132375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._ModelFromSite_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051D7 RID: 20951 RVA: 0x0001F810 File Offset: 0x0001DA10
			public _ModelFromSite_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B98 RID: 7064
			// (get) Token: 0x060051D8 RID: 20952 RVA: 0x0015D6DC File Offset: 0x0015B8DC
			// (set) Token: 0x060051D9 RID: 20953 RVA: 0x0001F819 File Offset: 0x0001DA19
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._ModelFromSite_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._ModelFromSite_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B99 RID: 7065
			// (get) Token: 0x060051DA RID: 20954 RVA: 0x0015D704 File Offset: 0x0015B904
			// (set) Token: 0x060051DB RID: 20955 RVA: 0x0001F834 File Offset: 0x0001DA34
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._ModelFromSite_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._ModelFromSite_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B9A RID: 7066
			// (get) Token: 0x060051DC RID: 20956 RVA: 0x0015D734 File Offset: 0x0015B934
			// (set) Token: 0x060051DD RID: 20957 RVA: 0x0001F853 File Offset: 0x0001DA53
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._ModelFromSite_d__12.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._ModelFromSite_d__12.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x17001B9B RID: 7067
			// (get) Token: 0x060051DE RID: 20958 RVA: 0x0015D75C File Offset: 0x0015B95C
			// (set) Token: 0x060051DF RID: 20959 RVA: 0x0001F86E File Offset: 0x0001DA6E
			public unsafe GameIO __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._ModelFromSite_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameIO>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._ModelFromSite_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B9C RID: 7068
			// (get) Token: 0x060051E0 RID: 20960 RVA: 0x0015D78C File Offset: 0x0015B98C
			// (set) Token: 0x060051E1 RID: 20961 RVA: 0x0001F88D File Offset: 0x0001DA8D
			public unsafe Instance parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._ModelFromSite_d__12.NativeFieldInfoPtr_parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._ModelFromSite_d__12.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B9D RID: 7069
			// (get) Token: 0x060051E2 RID: 20962 RVA: 0x0015D7BC File Offset: 0x0015B9BC
			// (set) Token: 0x060051E3 RID: 20963 RVA: 0x0001F8AC File Offset: 0x0001DAAC
			public unsafe Action<Instance> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._ModelFromSite_d__12.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Instance>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._ModelFromSite_d__12.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B9E RID: 7070
			// (get) Token: 0x060051E4 RID: 20964 RVA: 0x0015D7EC File Offset: 0x0015B9EC
			// (set) Token: 0x060051E5 RID: 20965 RVA: 0x0001F8CB File Offset: 0x0001DACB
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._ModelFromSite_d__12.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._ModelFromSite_d__12.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003EC4 RID: 16068
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003EC5 RID: 16069
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003EC6 RID: 16070
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04003EC7 RID: 16071
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003EC8 RID: 16072
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x04003EC9 RID: 16073
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04003ECA RID: 16074
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003ECB RID: 16075
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003ECC RID: 16076
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003ECD RID: 16077
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003ECE RID: 16078
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003ECF RID: 16079
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003ED0 RID: 16080
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003ED1 RID: 16081
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x0200042B RID: 1067
		[ObfuscatedName("Polytoria.Controllers.GameIO+<PostClearDatamodel>d__10")]
		public sealed class _PostClearDatamodel_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x060051E6 RID: 20966 RVA: 0x0015D81C File Offset: 0x0015BA1C
			// Note: this type is marked as 'beforefieldinit'.
			static _PostClearDatamodel_d__10()
			{
				Il2CppClassPointerStore<GameIO._PostClearDatamodel_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameIO>.NativeClassPtr, "<PostClearDatamodel>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameIO._PostClearDatamodel_d__10>.NativeClassPtr);
				GameIO._PostClearDatamodel_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO._PostClearDatamodel_d__10>.NativeClassPtr, "<>1__state");
				GameIO._PostClearDatamodel_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO._PostClearDatamodel_d__10>.NativeClassPtr, "<>2__current");
				GameIO._PostClearDatamodel_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameIO._PostClearDatamodel_d__10>.NativeClassPtr, "<>4__this");
				GameIO._PostClearDatamodel_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._PostClearDatamodel_d__10>.NativeClassPtr, 100674321);
				GameIO._PostClearDatamodel_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._PostClearDatamodel_d__10>.NativeClassPtr, 100674323);
				GameIO._PostClearDatamodel_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._PostClearDatamodel_d__10>.NativeClassPtr, 100674318);
				GameIO._PostClearDatamodel_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._PostClearDatamodel_d__10>.NativeClassPtr, 100674319);
				GameIO._PostClearDatamodel_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._PostClearDatamodel_d__10>.NativeClassPtr, 100674320);
				GameIO._PostClearDatamodel_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameIO._PostClearDatamodel_d__10>.NativeClassPtr, 100674322);
			}

			// Token: 0x17001BA4 RID: 7076
			// (get) Token: 0x060051E7 RID: 20967 RVA: 0x0015D8FC File Offset: 0x0015BAFC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._PostClearDatamodel_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001BA5 RID: 7077
			// (get) Token: 0x060051E8 RID: 20968 RVA: 0x0015D93C File Offset: 0x0015BB3C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._PostClearDatamodel_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060051E9 RID: 20969 RVA: 0x0015D97C File Offset: 0x0015BB7C
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PostClearDatamodel_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameIO._PostClearDatamodel_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._PostClearDatamodel_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051EA RID: 20970 RVA: 0x0015D9C4 File Offset: 0x0015BBC4
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._PostClearDatamodel_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051EB RID: 20971 RVA: 0x0015D9F8 File Offset: 0x0015BBF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132375, XrefRangeEnd = 132380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._PostClearDatamodel_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051EC RID: 20972 RVA: 0x0015DA34 File Offset: 0x0015BC34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132380, XrefRangeEnd = 132385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameIO._PostClearDatamodel_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051ED RID: 20973 RVA: 0x0001F8EA File Offset: 0x0001DAEA
			public _PostClearDatamodel_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BA1 RID: 7073
			// (get) Token: 0x060051EE RID: 20974 RVA: 0x0015DA68 File Offset: 0x0015BC68
			// (set) Token: 0x060051EF RID: 20975 RVA: 0x0001F8F3 File Offset: 0x0001DAF3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._PostClearDatamodel_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._PostClearDatamodel_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BA2 RID: 7074
			// (get) Token: 0x060051F0 RID: 20976 RVA: 0x0015DA90 File Offset: 0x0015BC90
			// (set) Token: 0x060051F1 RID: 20977 RVA: 0x0001F90E File Offset: 0x0001DB0E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._PostClearDatamodel_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._PostClearDatamodel_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BA3 RID: 7075
			// (get) Token: 0x060051F2 RID: 20978 RVA: 0x0015DAC0 File Offset: 0x0015BCC0
			// (set) Token: 0x060051F3 RID: 20979 RVA: 0x0001F92D File Offset: 0x0001DB2D
			public unsafe GameIO __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._PostClearDatamodel_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameIO>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameIO._PostClearDatamodel_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003ED2 RID: 16082
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003ED3 RID: 16083
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003ED4 RID: 16084
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003ED5 RID: 16085
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003ED6 RID: 16086
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003ED7 RID: 16087
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003ED8 RID: 16088
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003ED9 RID: 16089
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003EDA RID: 16090
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
