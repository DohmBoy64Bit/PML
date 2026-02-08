using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002F7 RID: 759
	public class SoundProxy : DynamicInstanceProxy
	{
		// Token: 0x06004249 RID: 16969 RVA: 0x00129CC0 File Offset: 0x00127EC0
		// Note: this type is marked as 'beforefieldinit'.
		static SoundProxy()
		{
			Il2CppClassPointerStore<SoundProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "SoundProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr);
			SoundProxy.NativeFieldInfoPtr_sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, "sound");
			SoundProxy.NativeMethodInfoPtr_get_Playing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673762);
			SoundProxy.NativeMethodInfoPtr_get_SoundID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673763);
			SoundProxy.NativeMethodInfoPtr_set_SoundID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673764);
			SoundProxy.NativeMethodInfoPtr_get_Pitch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673765);
			SoundProxy.NativeMethodInfoPtr_set_Pitch_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673766);
			SoundProxy.NativeMethodInfoPtr_get_Length_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673767);
			SoundProxy.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673768);
			SoundProxy.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673769);
			SoundProxy.NativeMethodInfoPtr_get_Rotation_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673770);
			SoundProxy.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673771);
			SoundProxy.NativeMethodInfoPtr_get_Time_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673772);
			SoundProxy.NativeMethodInfoPtr_set_Time_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673773);
			SoundProxy.NativeMethodInfoPtr_get_Autoplay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673774);
			SoundProxy.NativeMethodInfoPtr_set_Autoplay_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673775);
			SoundProxy.NativeMethodInfoPtr_get_Loop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673776);
			SoundProxy.NativeMethodInfoPtr_set_Loop_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673777);
			SoundProxy.NativeMethodInfoPtr_get_PlayInWorld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673778);
			SoundProxy.NativeMethodInfoPtr_set_PlayInWorld_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673779);
			SoundProxy.NativeMethodInfoPtr_get_Volume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673780);
			SoundProxy.NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673781);
			SoundProxy.NativeMethodInfoPtr_get_MaxDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673782);
			SoundProxy.NativeMethodInfoPtr_set_MaxDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673783);
			SoundProxy.NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673784);
			SoundProxy.NativeMethodInfoPtr_get_Loaded_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673788);
			SoundProxy.NativeMethodInfoPtr__ctor_Public_Void_Sound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673761);
			SoundProxy.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673785);
			SoundProxy.NativeMethodInfoPtr_PlayOneShot_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673786);
			SoundProxy.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr, 100673787);
		}

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x0600424A RID: 16970 RVA: 0x00129F34 File Offset: 0x00128134
		public unsafe bool Playing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_get_Playing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x0600424B RID: 16971 RVA: 0x00129F70 File Offset: 0x00128170
		// (set) Token: 0x0600424C RID: 16972 RVA: 0x00129FAC File Offset: 0x001281AC
		public unsafe int SoundID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_get_SoundID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128990, XrefRangeEnd = 128992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_set_SoundID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x0600424D RID: 16973 RVA: 0x00129FEC File Offset: 0x001281EC
		// (set) Token: 0x0600424E RID: 16974 RVA: 0x0012A028 File Offset: 0x00128228
		public unsafe float Pitch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_get_Pitch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128992, XrefRangeEnd = 128994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_set_Pitch_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x0600424F RID: 16975 RVA: 0x0012A068 File Offset: 0x00128268
		public unsafe float Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128994, XrefRangeEnd = 128996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_get_Length_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x06004250 RID: 16976 RVA: 0x0012A0A4 File Offset: 0x001282A4
		// (set) Token: 0x06004251 RID: 16977 RVA: 0x0012A0E4 File Offset: 0x001282E4
		public new unsafe Vector3 Size
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128996, XrefRangeEnd = 128997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128997, XrefRangeEnd = 128998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x06004252 RID: 16978 RVA: 0x0012A128 File Offset: 0x00128328
		// (set) Token: 0x06004253 RID: 16979 RVA: 0x0012A168 File Offset: 0x00128368
		public new unsafe Vector3 Rotation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_get_Rotation_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128998, XrefRangeEnd = 128999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x06004254 RID: 16980 RVA: 0x0012A1AC File Offset: 0x001283AC
		// (set) Token: 0x06004255 RID: 16981 RVA: 0x0012A1E8 File Offset: 0x001283E8
		public unsafe float Time
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128999, XrefRangeEnd = 129001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_get_Time_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129001, XrefRangeEnd = 129003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_set_Time_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x06004256 RID: 16982 RVA: 0x0012A228 File Offset: 0x00128428
		// (set) Token: 0x06004257 RID: 16983 RVA: 0x0012A264 File Offset: 0x00128464
		public unsafe bool Autoplay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_get_Autoplay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129003, XrefRangeEnd = 129005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_set_Autoplay_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x06004258 RID: 16984 RVA: 0x0012A2A4 File Offset: 0x001284A4
		// (set) Token: 0x06004259 RID: 16985 RVA: 0x0012A2E0 File Offset: 0x001284E0
		public unsafe bool Loop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_get_Loop_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129005, XrefRangeEnd = 129007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_set_Loop_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x0600425A RID: 16986 RVA: 0x0012A320 File Offset: 0x00128520
		// (set) Token: 0x0600425B RID: 16987 RVA: 0x0012A35C File Offset: 0x0012855C
		public unsafe bool PlayInWorld
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_get_PlayInWorld_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129007, XrefRangeEnd = 129009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_set_PlayInWorld_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x0600425C RID: 16988 RVA: 0x0012A39C File Offset: 0x0012859C
		// (set) Token: 0x0600425D RID: 16989 RVA: 0x0012A3D8 File Offset: 0x001285D8
		public unsafe float Volume
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129009, XrefRangeEnd = 129011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_get_Volume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129011, XrefRangeEnd = 129013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x0600425E RID: 16990 RVA: 0x0012A418 File Offset: 0x00128618
		// (set) Token: 0x0600425F RID: 16991 RVA: 0x0012A454 File Offset: 0x00128654
		public unsafe float MaxDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_get_MaxDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129013, XrefRangeEnd = 129015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_set_MaxDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x06004260 RID: 16992 RVA: 0x0012A494 File Offset: 0x00128694
		public unsafe bool Loading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x06004261 RID: 16993 RVA: 0x0012A4D0 File Offset: 0x001286D0
		public unsafe LuaEvent Loaded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_get_Loaded_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06004262 RID: 16994 RVA: 0x0012A510 File Offset: 0x00128710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoundProxy(Sound target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoundProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr__ctor_Public_Void_Sound_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x0012A55C File Offset: 0x0012875C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129015, XrefRangeEnd = 129017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x0012A590 File Offset: 0x00128790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129017, XrefRangeEnd = 129019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayOneShot(float volume = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref volume;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_PlayOneShot_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x0012A5D0 File Offset: 0x001287D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129019, XrefRangeEnd = 129021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoundProxy.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x00018AD9 File Offset: 0x00016CD9
		public SoundProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x06004267 RID: 16999 RVA: 0x0012A604 File Offset: 0x00128804
		// (set) Token: 0x06004268 RID: 17000 RVA: 0x00018AE2 File Offset: 0x00016CE2
		public unsafe Sound sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundProxy.NativeFieldInfoPtr_sound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sound>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoundProxy.NativeFieldInfoPtr_sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033A3 RID: 13219
		private static readonly IntPtr NativeFieldInfoPtr_sound;

		// Token: 0x040033A4 RID: 13220
		private static readonly IntPtr NativeMethodInfoPtr_get_Playing_Public_get_Boolean_0;

		// Token: 0x040033A5 RID: 13221
		private static readonly IntPtr NativeMethodInfoPtr_get_SoundID_Public_get_Int32_0;

		// Token: 0x040033A6 RID: 13222
		private static readonly IntPtr NativeMethodInfoPtr_set_SoundID_Public_set_Void_Int32_0;

		// Token: 0x040033A7 RID: 13223
		private static readonly IntPtr NativeMethodInfoPtr_get_Pitch_Public_get_Single_0;

		// Token: 0x040033A8 RID: 13224
		private static readonly IntPtr NativeMethodInfoPtr_set_Pitch_Public_set_Void_Single_0;

		// Token: 0x040033A9 RID: 13225
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Single_0;

		// Token: 0x040033AA RID: 13226
		private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_get_Vector3_0;

		// Token: 0x040033AB RID: 13227
		private static readonly IntPtr NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0;

		// Token: 0x040033AC RID: 13228
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Vector3_0;

		// Token: 0x040033AD RID: 13229
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Vector3_0;

		// Token: 0x040033AE RID: 13230
		private static readonly IntPtr NativeMethodInfoPtr_get_Time_Public_get_Single_0;

		// Token: 0x040033AF RID: 13231
		private static readonly IntPtr NativeMethodInfoPtr_set_Time_Public_set_Void_Single_0;

		// Token: 0x040033B0 RID: 13232
		private static readonly IntPtr NativeMethodInfoPtr_get_Autoplay_Public_get_Boolean_0;

		// Token: 0x040033B1 RID: 13233
		private static readonly IntPtr NativeMethodInfoPtr_set_Autoplay_Public_set_Void_Boolean_0;

		// Token: 0x040033B2 RID: 13234
		private static readonly IntPtr NativeMethodInfoPtr_get_Loop_Public_get_Boolean_0;

		// Token: 0x040033B3 RID: 13235
		private static readonly IntPtr NativeMethodInfoPtr_set_Loop_Public_set_Void_Boolean_0;

		// Token: 0x040033B4 RID: 13236
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayInWorld_Public_get_Boolean_0;

		// Token: 0x040033B5 RID: 13237
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayInWorld_Public_set_Void_Boolean_0;

		// Token: 0x040033B6 RID: 13238
		private static readonly IntPtr NativeMethodInfoPtr_get_Volume_Public_get_Single_0;

		// Token: 0x040033B7 RID: 13239
		private static readonly IntPtr NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0;

		// Token: 0x040033B8 RID: 13240
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxDistance_Public_get_Single_0;

		// Token: 0x040033B9 RID: 13241
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxDistance_Public_set_Void_Single_0;

		// Token: 0x040033BA RID: 13242
		private static readonly IntPtr NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0;

		// Token: 0x040033BB RID: 13243
		private static readonly IntPtr NativeMethodInfoPtr_get_Loaded_Public_get_LuaEvent_0;

		// Token: 0x040033BC RID: 13244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Sound_0;

		// Token: 0x040033BD RID: 13245
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x040033BE RID: 13246
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShot_Public_Void_Single_0;

		// Token: 0x040033BF RID: 13247
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
	}
}
