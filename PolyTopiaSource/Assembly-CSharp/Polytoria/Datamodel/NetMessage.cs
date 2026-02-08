using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000293 RID: 659
	public class NetMessage : global::Il2CppSystem.Object
	{
		// Token: 0x06003471 RID: 13425 RVA: 0x000EF2B0 File Offset: 0x000ED4B0
		// Note: this type is marked as 'beforefieldinit'.
		static NetMessage()
		{
			Il2CppClassPointerStore<NetMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "NetMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetMessage>.NativeClassPtr);
			NetMessage.NativeFieldInfoPtr_strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, "strings");
			NetMessage.NativeFieldInfoPtr_ints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, "ints");
			NetMessage.NativeFieldInfoPtr_numbers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, "numbers");
			NetMessage.NativeFieldInfoPtr_bools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, "bools");
			NetMessage.NativeFieldInfoPtr_vec2s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, "vec2s");
			NetMessage.NativeFieldInfoPtr_vec3s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, "vec3s");
			NetMessage.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, "colors");
			NetMessage.NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, "instances");
			NetMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, 100671229);
			NetMessage.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_String_Dictionary_2_String_Int32_Dictionary_2_String_Single_Dictionary_2_String_Boolean_Dictionary_2_String_Vector2_Dictionary_2_String_Vector3_Dictionary_2_String_Color_Dictionary_2_String_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, 100671247);
			NetMessage.NativeMethodInfoPtr_AddString_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, 100671230);
			NetMessage.NativeMethodInfoPtr_AddInt_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, 100671231);
			NetMessage.NativeMethodInfoPtr_AddBool_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, 100671232);
			NetMessage.NativeMethodInfoPtr_AddNumber_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, 100671233);
			NetMessage.NativeMethodInfoPtr_AddVector2_Public_Void_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, 100671234);
			NetMessage.NativeMethodInfoPtr_AddVector3_Public_Void_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, 100671235);
			NetMessage.NativeMethodInfoPtr_AddColor_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, 100671236);
			NetMessage.NativeMethodInfoPtr_AddInstance_Public_Void_String_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, 100671237);
			NetMessage.NativeMethodInfoPtr_GetString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, 100671238);
			NetMessage.NativeMethodInfoPtr_GetInt_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, 100671239);
			NetMessage.NativeMethodInfoPtr_GetNumber_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, 100671240);
			NetMessage.NativeMethodInfoPtr_GetBool_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, 100671241);
			NetMessage.NativeMethodInfoPtr_GetVector2_Public_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, 100671242);
			NetMessage.NativeMethodInfoPtr_GetVector3_Public_Vector3_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, 100671243);
			NetMessage.NativeMethodInfoPtr_GetColor_Public_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, 100671244);
			NetMessage.NativeMethodInfoPtr_GetInstance_Public_Instance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, 100671245);
			NetMessage.NativeMethodInfoPtr_New_Public_Static_NetMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMessage>.NativeClassPtr, 100671246);
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x000EF4FC File Offset: 0x000ED6FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107164, RefRangeEnd = 107165, XrefRangeStart = 107107, XrefRangeEnd = 107164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x000EF538 File Offset: 0x000ED738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107165, XrefRangeEnd = 107174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetMessage(Dictionary<string, string> strings, Dictionary<string, int> ints, Dictionary<string, float> numbers, Dictionary<string, bool> bools, Dictionary<string, Vector2> vec2s, Dictionary<string, Vector3> vec3s, Dictionary<string, Color> colors, Dictionary<string, Instance> instances)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(strings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ints);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numbers);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bools);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vec2s);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vec3s);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colors);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instances);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessage.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_String_Dictionary_2_String_Int32_Dictionary_2_String_Single_Dictionary_2_String_Boolean_Dictionary_2_String_Vector2_Dictionary_2_String_Vector3_Dictionary_2_String_Color_Dictionary_2_String_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x000EF608 File Offset: 0x000ED808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107174, XrefRangeEnd = 107178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddString(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessage.NativeMethodInfoPtr_AddString_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x000EF65C File Offset: 0x000ED85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107178, XrefRangeEnd = 107182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddInt(string key, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessage.NativeMethodInfoPtr_AddInt_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x000EF6AC File Offset: 0x000ED8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107182, XrefRangeEnd = 107186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBool(string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessage.NativeMethodInfoPtr_AddBool_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x000EF6FC File Offset: 0x000ED8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107186, XrefRangeEnd = 107190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNumber(string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessage.NativeMethodInfoPtr_AddNumber_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x000EF74C File Offset: 0x000ED94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107190, XrefRangeEnd = 107194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddVector2(string key, Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessage.NativeMethodInfoPtr_AddVector2_Public_Void_String_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x000EF7A0 File Offset: 0x000ED9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107194, XrefRangeEnd = 107197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddVector3(string key, Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessage.NativeMethodInfoPtr_AddVector3_Public_Void_String_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x000EF7F4 File Offset: 0x000ED9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107197, XrefRangeEnd = 107200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddColor(string key, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessage.NativeMethodInfoPtr_AddColor_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x000EF848 File Offset: 0x000EDA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107200, XrefRangeEnd = 107204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddInstance(string key, Instance value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessage.NativeMethodInfoPtr_AddInstance_Public_Void_String_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x000EF89C File Offset: 0x000EDA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107204, XrefRangeEnd = 107208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetString(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessage.NativeMethodInfoPtr_GetString_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x000EF8E4 File Offset: 0x000EDAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107208, XrefRangeEnd = 107212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInt(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessage.NativeMethodInfoPtr_GetInt_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x000EF934 File Offset: 0x000EDB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107212, XrefRangeEnd = 107216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNumber(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessage.NativeMethodInfoPtr_GetNumber_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600347F RID: 13439 RVA: 0x000EF984 File Offset: 0x000EDB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107216, XrefRangeEnd = 107220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetBool(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessage.NativeMethodInfoPtr_GetBool_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x000EF9D4 File Offset: 0x000EDBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107220, XrefRangeEnd = 107224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetVector2(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessage.NativeMethodInfoPtr_GetVector2_Public_Vector2_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x000EFA24 File Offset: 0x000EDC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107224, XrefRangeEnd = 107227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetVector3(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessage.NativeMethodInfoPtr_GetVector3_Public_Vector3_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x000EFA74 File Offset: 0x000EDC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107227, XrefRangeEnd = 107230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetColor(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessage.NativeMethodInfoPtr_GetColor_Public_Color_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x000EFAC4 File Offset: 0x000EDCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107230, XrefRangeEnd = 107234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instance GetInstance(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessage.NativeMethodInfoPtr_GetInstance_Public_Instance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
			}
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x000EFB14 File Offset: 0x000EDD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107234, XrefRangeEnd = 107238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NetMessage New()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMessage.NativeMethodInfoPtr_New_Public_Static_NetMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetMessage>(intPtr3) : null;
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x00014A3D File Offset: 0x00012C3D
		public NetMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x06003486 RID: 13446 RVA: 0x000EFB48 File Offset: 0x000EDD48
		// (set) Token: 0x06003487 RID: 13447 RVA: 0x00014A46 File Offset: 0x00012C46
		public unsafe Dictionary<string, string> strings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetMessage.NativeFieldInfoPtr_strings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetMessage.NativeFieldInfoPtr_strings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x06003488 RID: 13448 RVA: 0x000EFB78 File Offset: 0x000EDD78
		// (set) Token: 0x06003489 RID: 13449 RVA: 0x00014A65 File Offset: 0x00012C65
		public unsafe Dictionary<string, int> ints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetMessage.NativeFieldInfoPtr_ints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetMessage.NativeFieldInfoPtr_ints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x0600348A RID: 13450 RVA: 0x000EFBA8 File Offset: 0x000EDDA8
		// (set) Token: 0x0600348B RID: 13451 RVA: 0x00014A84 File Offset: 0x00012C84
		public unsafe Dictionary<string, float> numbers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetMessage.NativeFieldInfoPtr_numbers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetMessage.NativeFieldInfoPtr_numbers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x0600348C RID: 13452 RVA: 0x000EFBD8 File Offset: 0x000EDDD8
		// (set) Token: 0x0600348D RID: 13453 RVA: 0x00014AA3 File Offset: 0x00012CA3
		public unsafe Dictionary<string, bool> bools
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetMessage.NativeFieldInfoPtr_bools);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetMessage.NativeFieldInfoPtr_bools), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x0600348E RID: 13454 RVA: 0x000EFC08 File Offset: 0x000EDE08
		// (set) Token: 0x0600348F RID: 13455 RVA: 0x00014AC2 File Offset: 0x00012CC2
		public unsafe Dictionary<string, Vector2> vec2s
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetMessage.NativeFieldInfoPtr_vec2s);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetMessage.NativeFieldInfoPtr_vec2s), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x06003490 RID: 13456 RVA: 0x000EFC38 File Offset: 0x000EDE38
		// (set) Token: 0x06003491 RID: 13457 RVA: 0x00014AE1 File Offset: 0x00012CE1
		public unsafe Dictionary<string, Vector3> vec3s
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetMessage.NativeFieldInfoPtr_vec3s);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetMessage.NativeFieldInfoPtr_vec3s), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x06003492 RID: 13458 RVA: 0x000EFC68 File Offset: 0x000EDE68
		// (set) Token: 0x06003493 RID: 13459 RVA: 0x00014B00 File Offset: 0x00012D00
		public unsafe Dictionary<string, Color> colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetMessage.NativeFieldInfoPtr_colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetMessage.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x06003494 RID: 13460 RVA: 0x000EFC98 File Offset: 0x000EDE98
		// (set) Token: 0x06003495 RID: 13461 RVA: 0x00014B1F File Offset: 0x00012D1F
		public unsafe Dictionary<string, Instance> instances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetMessage.NativeFieldInfoPtr_instances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Instance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetMessage.NativeFieldInfoPtr_instances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002852 RID: 10322
		private static readonly IntPtr NativeFieldInfoPtr_strings;

		// Token: 0x04002853 RID: 10323
		private static readonly IntPtr NativeFieldInfoPtr_ints;

		// Token: 0x04002854 RID: 10324
		private static readonly IntPtr NativeFieldInfoPtr_numbers;

		// Token: 0x04002855 RID: 10325
		private static readonly IntPtr NativeFieldInfoPtr_bools;

		// Token: 0x04002856 RID: 10326
		private static readonly IntPtr NativeFieldInfoPtr_vec2s;

		// Token: 0x04002857 RID: 10327
		private static readonly IntPtr NativeFieldInfoPtr_vec3s;

		// Token: 0x04002858 RID: 10328
		private static readonly IntPtr NativeFieldInfoPtr_colors;

		// Token: 0x04002859 RID: 10329
		private static readonly IntPtr NativeFieldInfoPtr_instances;

		// Token: 0x0400285A RID: 10330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400285B RID: 10331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_String_Dictionary_2_String_Int32_Dictionary_2_String_Single_Dictionary_2_String_Boolean_Dictionary_2_String_Vector2_Dictionary_2_String_Vector3_Dictionary_2_String_Color_Dictionary_2_String_Instance_0;

		// Token: 0x0400285C RID: 10332
		private static readonly IntPtr NativeMethodInfoPtr_AddString_Public_Void_String_String_0;

		// Token: 0x0400285D RID: 10333
		private static readonly IntPtr NativeMethodInfoPtr_AddInt_Public_Void_String_Int32_0;

		// Token: 0x0400285E RID: 10334
		private static readonly IntPtr NativeMethodInfoPtr_AddBool_Public_Void_String_Boolean_0;

		// Token: 0x0400285F RID: 10335
		private static readonly IntPtr NativeMethodInfoPtr_AddNumber_Public_Void_String_Single_0;

		// Token: 0x04002860 RID: 10336
		private static readonly IntPtr NativeMethodInfoPtr_AddVector2_Public_Void_String_Vector2_0;

		// Token: 0x04002861 RID: 10337
		private static readonly IntPtr NativeMethodInfoPtr_AddVector3_Public_Void_String_Vector3_0;

		// Token: 0x04002862 RID: 10338
		private static readonly IntPtr NativeMethodInfoPtr_AddColor_Public_Void_String_Color_0;

		// Token: 0x04002863 RID: 10339
		private static readonly IntPtr NativeMethodInfoPtr_AddInstance_Public_Void_String_Instance_0;

		// Token: 0x04002864 RID: 10340
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_String_String_0;

		// Token: 0x04002865 RID: 10341
		private static readonly IntPtr NativeMethodInfoPtr_GetInt_Public_Int32_String_0;

		// Token: 0x04002866 RID: 10342
		private static readonly IntPtr NativeMethodInfoPtr_GetNumber_Public_Single_String_0;

		// Token: 0x04002867 RID: 10343
		private static readonly IntPtr NativeMethodInfoPtr_GetBool_Public_Boolean_String_0;

		// Token: 0x04002868 RID: 10344
		private static readonly IntPtr NativeMethodInfoPtr_GetVector2_Public_Vector2_String_0;

		// Token: 0x04002869 RID: 10345
		private static readonly IntPtr NativeMethodInfoPtr_GetVector3_Public_Vector3_String_0;

		// Token: 0x0400286A RID: 10346
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Color_String_0;

		// Token: 0x0400286B RID: 10347
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Public_Instance_String_0;

		// Token: 0x0400286C RID: 10348
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_NetMessage_0;
	}
}
