using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002E3 RID: 739
	public class MeshPartProxy : PartProxy
	{
		// Token: 0x060040B9 RID: 16569 RVA: 0x00122904 File Offset: 0x00120B04
		// Note: this type is marked as 'beforefieldinit'.
		static MeshPartProxy()
		{
			Il2CppClassPointerStore<MeshPartProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "MeshPartProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshPartProxy>.NativeClassPtr);
			MeshPartProxy.NativeFieldInfoPtr_meshPart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPartProxy>.NativeClassPtr, "meshPart");
			MeshPartProxy.NativeMethodInfoPtr_get_AssetID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartProxy>.NativeClassPtr, 100673442);
			MeshPartProxy.NativeMethodInfoPtr_set_AssetID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartProxy>.NativeClassPtr, 100673443);
			MeshPartProxy.NativeMethodInfoPtr_get_CurrentAnimation_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartProxy>.NativeClassPtr, 100673444);
			MeshPartProxy.NativeMethodInfoPtr_get_IsAnimationPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartProxy>.NativeClassPtr, 100673445);
			MeshPartProxy.NativeMethodInfoPtr_get_PlayAnimationOnStart_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartProxy>.NativeClassPtr, 100673446);
			MeshPartProxy.NativeMethodInfoPtr_set_PlayAnimationOnStart_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartProxy>.NativeClassPtr, 100673447);
			MeshPartProxy.NativeMethodInfoPtr_get_CollisionType_Public_get_CollisionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartProxy>.NativeClassPtr, 100673453);
			MeshPartProxy.NativeMethodInfoPtr_set_CollisionType_Public_set_Void_CollisionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartProxy>.NativeClassPtr, 100673454);
			MeshPartProxy.NativeMethodInfoPtr__ctor_Public_Void_MeshPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartProxy>.NativeClassPtr, 100673441);
			MeshPartProxy.NativeMethodInfoPtr_PlayAnimation_Public_Void_String_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartProxy>.NativeClassPtr, 100673448);
			MeshPartProxy.NativeMethodInfoPtr_StopAnimation_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartProxy>.NativeClassPtr, 100673449);
			MeshPartProxy.NativeMethodInfoPtr_GetAnimations_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartProxy>.NativeClassPtr, 100673450);
			MeshPartProxy.NativeMethodInfoPtr_GetAnimationSources_Public_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartProxy>.NativeClassPtr, 100673451);
			MeshPartProxy.NativeMethodInfoPtr_GetAnimationInfo_Public_Il2CppReferenceArray_1_AnimationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPartProxy>.NativeClassPtr, 100673452);
		}

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x060040BA RID: 16570 RVA: 0x00122A60 File Offset: 0x00120C60
		// (set) Token: 0x060040BB RID: 16571 RVA: 0x00122A9C File Offset: 0x00120C9C
		public unsafe int AssetID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartProxy.NativeMethodInfoPtr_get_AssetID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128646, XrefRangeEnd = 128648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartProxy.NativeMethodInfoPtr_set_AssetID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x060040BC RID: 16572 RVA: 0x00122ADC File Offset: 0x00120CDC
		public unsafe string CurrentAnimation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128648, XrefRangeEnd = 128650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartProxy.NativeMethodInfoPtr_get_CurrentAnimation_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x060040BD RID: 16573 RVA: 0x00122B14 File Offset: 0x00120D14
		public unsafe bool IsAnimationPlaying
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128650, XrefRangeEnd = 128652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartProxy.NativeMethodInfoPtr_get_IsAnimationPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x060040BE RID: 16574 RVA: 0x00122B50 File Offset: 0x00120D50
		// (set) Token: 0x060040BF RID: 16575 RVA: 0x00122B8C File Offset: 0x00120D8C
		public unsafe bool PlayAnimationOnStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartProxy.NativeMethodInfoPtr_get_PlayAnimationOnStart_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128652, XrefRangeEnd = 128654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartProxy.NativeMethodInfoPtr_set_PlayAnimationOnStart_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x060040C0 RID: 16576 RVA: 0x00122BCC File Offset: 0x00120DCC
		// (set) Token: 0x060040C1 RID: 16577 RVA: 0x00122C0C File Offset: 0x00120E0C
		public unsafe CollisionType CollisionType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartProxy.NativeMethodInfoPtr_get_CollisionType_Public_get_CollisionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CollisionType>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128654, XrefRangeEnd = 128656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartProxy.NativeMethodInfoPtr_set_CollisionType_Public_set_Void_CollisionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x00122C50 File Offset: 0x00120E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshPartProxy(MeshPart target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshPartProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartProxy.NativeMethodInfoPtr__ctor_Public_Void_MeshPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x00122C9C File Offset: 0x00120E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128656, XrefRangeEnd = 128658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayAnimation(string animationName, string objectPath, float speed = 1f, bool loop = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(animationName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartProxy.NativeMethodInfoPtr_PlayAnimation_Public_Void_String_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x00122D0C File Offset: 0x00120F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128658, XrefRangeEnd = 128660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAnimation(string name = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartProxy.NativeMethodInfoPtr_StopAnimation_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x00122D50 File Offset: 0x00120F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128660, XrefRangeEnd = 128662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetAnimations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartProxy.NativeMethodInfoPtr_GetAnimations_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060040C6 RID: 16582 RVA: 0x00122D90 File Offset: 0x00120F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128662, XrefRangeEnd = 128664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetAnimationSources(string animationName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(animationName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartProxy.NativeMethodInfoPtr_GetAnimationSources_Public_Il2CppStringArray_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x00122DE0 File Offset: 0x00120FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128664, XrefRangeEnd = 128666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<AnimationInfo> GetAnimationInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshPartProxy.NativeMethodInfoPtr_GetAnimationInfo_Public_Il2CppReferenceArray_1_AnimationInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimationInfo>>(intPtr3) : null;
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x000187B9 File Offset: 0x000169B9
		public MeshPartProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x060040C9 RID: 16585 RVA: 0x00122E20 File Offset: 0x00121020
		// (set) Token: 0x060040CA RID: 16586 RVA: 0x000187C2 File Offset: 0x000169C2
		public unsafe MeshPart meshPart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartProxy.NativeFieldInfoPtr_meshPart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshPart>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshPartProxy.NativeFieldInfoPtr_meshPart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400324F RID: 12879
		private static readonly IntPtr NativeFieldInfoPtr_meshPart;

		// Token: 0x04003250 RID: 12880
		private static readonly IntPtr NativeMethodInfoPtr_get_AssetID_Public_get_Int32_0;

		// Token: 0x04003251 RID: 12881
		private static readonly IntPtr NativeMethodInfoPtr_set_AssetID_Public_set_Void_Int32_0;

		// Token: 0x04003252 RID: 12882
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentAnimation_Public_get_String_0;

		// Token: 0x04003253 RID: 12883
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAnimationPlaying_Public_get_Boolean_0;

		// Token: 0x04003254 RID: 12884
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayAnimationOnStart_Public_get_Boolean_0;

		// Token: 0x04003255 RID: 12885
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayAnimationOnStart_Public_set_Void_Boolean_0;

		// Token: 0x04003256 RID: 12886
		private static readonly IntPtr NativeMethodInfoPtr_get_CollisionType_Public_get_CollisionType_0;

		// Token: 0x04003257 RID: 12887
		private static readonly IntPtr NativeMethodInfoPtr_set_CollisionType_Public_set_Void_CollisionType_0;

		// Token: 0x04003258 RID: 12888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MeshPart_0;

		// Token: 0x04003259 RID: 12889
		private static readonly IntPtr NativeMethodInfoPtr_PlayAnimation_Public_Void_String_String_Single_Boolean_0;

		// Token: 0x0400325A RID: 12890
		private static readonly IntPtr NativeMethodInfoPtr_StopAnimation_Public_Void_String_0;

		// Token: 0x0400325B RID: 12891
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimations_Public_Il2CppStringArray_0;

		// Token: 0x0400325C RID: 12892
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimationSources_Public_Il2CppStringArray_String_0;

		// Token: 0x0400325D RID: 12893
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimationInfo_Public_Il2CppReferenceArray_1_AnimationInfo_0;
	}
}
