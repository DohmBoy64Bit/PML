using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x020001BC RID: 444
	public class SceneRaycastHit : Object
	{
		// Token: 0x0600225E RID: 8798 RVA: 0x000A9928 File Offset: 0x000A7B28
		// Note: this type is marked as 'beforefieldinit'.
		static SceneRaycastHit()
		{
			Il2CppClassPointerStore<SceneRaycastHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SceneRaycastHit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneRaycastHit>.NativeClassPtr);
			SceneRaycastHit.NativeFieldInfoPtr__objectHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRaycastHit>.NativeClassPtr, "_objectHit");
			SceneRaycastHit.NativeFieldInfoPtr__gridHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRaycastHit>.NativeClassPtr, "_gridHit");
			SceneRaycastHit.NativeMethodInfoPtr_get_WasAnythingHit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRaycastHit>.NativeClassPtr, 100668488);
			SceneRaycastHit.NativeMethodInfoPtr_get_WasAnObjectHit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRaycastHit>.NativeClassPtr, 100668489);
			SceneRaycastHit.NativeMethodInfoPtr_get_WasGridHit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRaycastHit>.NativeClassPtr, 100668490);
			SceneRaycastHit.NativeMethodInfoPtr_get_ObjectHit_Public_get_GameObjectRayHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRaycastHit>.NativeClassPtr, 100668491);
			SceneRaycastHit.NativeMethodInfoPtr_get_GridHit_Public_get_XZGridRayHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRaycastHit>.NativeClassPtr, 100668492);
			SceneRaycastHit.NativeMethodInfoPtr__ctor_Public_Void_GameObjectRayHit_XZGridRayHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRaycastHit>.NativeClassPtr, 100668493);
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x0600225F RID: 8799 RVA: 0x000A99F8 File Offset: 0x000A7BF8
		public unsafe bool WasAnythingHit
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 87063, RefRangeEnd = 87064, XrefRangeStart = 87063, XrefRangeEnd = 87063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneRaycastHit.NativeMethodInfoPtr_get_WasAnythingHit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x000A9A34 File Offset: 0x000A7C34
		public unsafe bool WasAnObjectHit
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 87064, RefRangeEnd = 87066, XrefRangeStart = 87064, XrefRangeEnd = 87064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneRaycastHit.NativeMethodInfoPtr_get_WasAnObjectHit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06002261 RID: 8801 RVA: 0x000A9A70 File Offset: 0x000A7C70
		public unsafe bool WasGridHit
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 25739, RefRangeEnd = 25748, XrefRangeStart = 25739, XrefRangeEnd = 25748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneRaycastHit.NativeMethodInfoPtr_get_WasGridHit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x000A9AAC File Offset: 0x000A7CAC
		public unsafe GameObjectRayHit ObjectHit
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneRaycastHit.NativeMethodInfoPtr_get_ObjectHit_Public_get_GameObjectRayHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObjectRayHit>(intPtr3) : null;
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06002263 RID: 8803 RVA: 0x000A9AEC File Offset: 0x000A7CEC
		public unsafe XZGridRayHit GridHit
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneRaycastHit.NativeMethodInfoPtr_get_GridHit_Public_get_XZGridRayHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XZGridRayHit>(intPtr3) : null;
			}
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x000A9B2C File Offset: 0x000A7D2C
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 33819, RefRangeEnd = 33846, XrefRangeStart = 33819, XrefRangeEnd = 33846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneRaycastHit(GameObjectRayHit objectRayHit, XZGridRayHit gridRayHit)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneRaycastHit>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectRayHit);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gridRayHit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneRaycastHit.NativeMethodInfoPtr__ctor_Public_Void_GameObjectRayHit_XZGridRayHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x0000E0AC File Offset: 0x0000C2AC
		public SceneRaycastHit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06002266 RID: 8806 RVA: 0x000A9B8C File Offset: 0x000A7D8C
		// (set) Token: 0x06002267 RID: 8807 RVA: 0x0000E0B5 File Offset: 0x0000C2B5
		public unsafe GameObjectRayHit _objectHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneRaycastHit.NativeFieldInfoPtr__objectHit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObjectRayHit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneRaycastHit.NativeFieldInfoPtr__objectHit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x000A9BBC File Offset: 0x000A7DBC
		// (set) Token: 0x06002269 RID: 8809 RVA: 0x0000E0D4 File Offset: 0x0000C2D4
		public unsafe XZGridRayHit _gridHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneRaycastHit.NativeFieldInfoPtr__gridHit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XZGridRayHit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneRaycastHit.NativeFieldInfoPtr__gridHit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AB2 RID: 6834
		private static readonly IntPtr NativeFieldInfoPtr__objectHit;

		// Token: 0x04001AB3 RID: 6835
		private static readonly IntPtr NativeFieldInfoPtr__gridHit;

		// Token: 0x04001AB4 RID: 6836
		private static readonly IntPtr NativeMethodInfoPtr_get_WasAnythingHit_Public_get_Boolean_0;

		// Token: 0x04001AB5 RID: 6837
		private static readonly IntPtr NativeMethodInfoPtr_get_WasAnObjectHit_Public_get_Boolean_0;

		// Token: 0x04001AB6 RID: 6838
		private static readonly IntPtr NativeMethodInfoPtr_get_WasGridHit_Public_get_Boolean_0;

		// Token: 0x04001AB7 RID: 6839
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectHit_Public_get_GameObjectRayHit_0;

		// Token: 0x04001AB8 RID: 6840
		private static readonly IntPtr NativeMethodInfoPtr_get_GridHit_Public_get_XZGridRayHit_0;

		// Token: 0x04001AB9 RID: 6841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObjectRayHit_XZGridRayHit_0;
	}
}
