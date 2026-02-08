using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x020000FC RID: 252
	[Serializable]
	public class CameraHotkeys : Settings
	{
		// Token: 0x0600185F RID: 6239 RVA: 0x000806D4 File Offset: 0x0007E8D4
		// Note: this type is marked as 'beforefieldinit'.
		static CameraHotkeys()
		{
			Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "CameraHotkeys");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr);
			CameraHotkeys.NativeFieldInfoPtr__moveForward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, "_moveForward");
			CameraHotkeys.NativeFieldInfoPtr__moveBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, "_moveBack");
			CameraHotkeys.NativeFieldInfoPtr__strafeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, "_strafeLeft");
			CameraHotkeys.NativeFieldInfoPtr__strafeRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, "_strafeRight");
			CameraHotkeys.NativeFieldInfoPtr__moveUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, "_moveUp");
			CameraHotkeys.NativeFieldInfoPtr__moveDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, "_moveDown");
			CameraHotkeys.NativeFieldInfoPtr__pan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, "_pan");
			CameraHotkeys.NativeFieldInfoPtr__lookAround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, "_lookAround");
			CameraHotkeys.NativeFieldInfoPtr__orbit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, "_orbit");
			CameraHotkeys.NativeFieldInfoPtr__alternateMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, "_alternateMoveSpeed");
			CameraHotkeys.NativeMethodInfoPtr_get_MoveForward_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, 100666899);
			CameraHotkeys.NativeMethodInfoPtr_get_MoveBack_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, 100666900);
			CameraHotkeys.NativeMethodInfoPtr_get_StrafeLeft_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, 100666901);
			CameraHotkeys.NativeMethodInfoPtr_get_StrafeRight_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, 100666902);
			CameraHotkeys.NativeMethodInfoPtr_get_MoveUp_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, 100666903);
			CameraHotkeys.NativeMethodInfoPtr_get_MoveDown_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, 100666904);
			CameraHotkeys.NativeMethodInfoPtr_get_Pan_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, 100666905);
			CameraHotkeys.NativeMethodInfoPtr_get_LookAround_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, 100666906);
			CameraHotkeys.NativeMethodInfoPtr_get_Orbit_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, 100666907);
			CameraHotkeys.NativeMethodInfoPtr_get_AlternateMoveSpeed_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, 100666908);
			CameraHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr, 100666909);
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001860 RID: 6240 RVA: 0x000808A8 File Offset: 0x0007EAA8
		public unsafe Hotkeys MoveForward
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraHotkeys.NativeMethodInfoPtr_get_MoveForward_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001861 RID: 6241 RVA: 0x000808E8 File Offset: 0x0007EAE8
		public unsafe Hotkeys MoveBack
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraHotkeys.NativeMethodInfoPtr_get_MoveBack_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x00080928 File Offset: 0x0007EB28
		public unsafe Hotkeys StrafeLeft
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraHotkeys.NativeMethodInfoPtr_get_StrafeLeft_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001863 RID: 6243 RVA: 0x00080968 File Offset: 0x0007EB68
		public unsafe Hotkeys StrafeRight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraHotkeys.NativeMethodInfoPtr_get_StrafeRight_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x000809A8 File Offset: 0x0007EBA8
		public unsafe Hotkeys MoveUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraHotkeys.NativeMethodInfoPtr_get_MoveUp_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x000809E8 File Offset: 0x0007EBE8
		public unsafe Hotkeys MoveDown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraHotkeys.NativeMethodInfoPtr_get_MoveDown_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x00080A28 File Offset: 0x0007EC28
		public unsafe Hotkeys Pan
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraHotkeys.NativeMethodInfoPtr_get_Pan_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x00080A68 File Offset: 0x0007EC68
		public unsafe Hotkeys LookAround
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraHotkeys.NativeMethodInfoPtr_get_LookAround_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x00080AA8 File Offset: 0x0007ECA8
		public unsafe Hotkeys Orbit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraHotkeys.NativeMethodInfoPtr_get_Orbit_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001869 RID: 6249 RVA: 0x00080AE8 File Offset: 0x0007ECE8
		public unsafe Hotkeys AlternateMoveSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraHotkeys.NativeMethodInfoPtr_get_AlternateMoveSpeed_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x00080B28 File Offset: 0x0007ED28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74482, RefRangeEnd = 74483, XrefRangeStart = 74409, XrefRangeEnd = 74482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraHotkeys()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraHotkeys>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x0000ABE3 File Offset: 0x00008DE3
		public CameraHotkeys(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x0600186C RID: 6252 RVA: 0x00080B64 File Offset: 0x0007ED64
		// (set) Token: 0x0600186D RID: 6253 RVA: 0x0000ABEC File Offset: 0x00008DEC
		public unsafe Hotkeys _moveForward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__moveForward);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__moveForward), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x00080B94 File Offset: 0x0007ED94
		// (set) Token: 0x0600186F RID: 6255 RVA: 0x0000AC0B File Offset: 0x00008E0B
		public unsafe Hotkeys _moveBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__moveBack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__moveBack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x00080BC4 File Offset: 0x0007EDC4
		// (set) Token: 0x06001871 RID: 6257 RVA: 0x0000AC2A File Offset: 0x00008E2A
		public unsafe Hotkeys _strafeLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__strafeLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__strafeLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x00080BF4 File Offset: 0x0007EDF4
		// (set) Token: 0x06001873 RID: 6259 RVA: 0x0000AC49 File Offset: 0x00008E49
		public unsafe Hotkeys _strafeRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__strafeRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__strafeRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x00080C24 File Offset: 0x0007EE24
		// (set) Token: 0x06001875 RID: 6261 RVA: 0x0000AC68 File Offset: 0x00008E68
		public unsafe Hotkeys _moveUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__moveUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__moveUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x00080C54 File Offset: 0x0007EE54
		// (set) Token: 0x06001877 RID: 6263 RVA: 0x0000AC87 File Offset: 0x00008E87
		public unsafe Hotkeys _moveDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__moveDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__moveDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x00080C84 File Offset: 0x0007EE84
		// (set) Token: 0x06001879 RID: 6265 RVA: 0x0000ACA6 File Offset: 0x00008EA6
		public unsafe Hotkeys _pan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__pan);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__pan), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x00080CB4 File Offset: 0x0007EEB4
		// (set) Token: 0x0600187B RID: 6267 RVA: 0x0000ACC5 File Offset: 0x00008EC5
		public unsafe Hotkeys _lookAround
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__lookAround);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__lookAround), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x00080CE4 File Offset: 0x0007EEE4
		// (set) Token: 0x0600187D RID: 6269 RVA: 0x0000ACE4 File Offset: 0x00008EE4
		public unsafe Hotkeys _orbit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__orbit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__orbit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x00080D14 File Offset: 0x0007EF14
		// (set) Token: 0x0600187F RID: 6271 RVA: 0x0000AD03 File Offset: 0x00008F03
		public unsafe Hotkeys _alternateMoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__alternateMoveSpeed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraHotkeys.NativeFieldInfoPtr__alternateMoveSpeed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001299 RID: 4761
		private static readonly IntPtr NativeFieldInfoPtr__moveForward;

		// Token: 0x0400129A RID: 4762
		private static readonly IntPtr NativeFieldInfoPtr__moveBack;

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeFieldInfoPtr__strafeLeft;

		// Token: 0x0400129C RID: 4764
		private static readonly IntPtr NativeFieldInfoPtr__strafeRight;

		// Token: 0x0400129D RID: 4765
		private static readonly IntPtr NativeFieldInfoPtr__moveUp;

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeFieldInfoPtr__moveDown;

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeFieldInfoPtr__pan;

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeFieldInfoPtr__lookAround;

		// Token: 0x040012A1 RID: 4769
		private static readonly IntPtr NativeFieldInfoPtr__orbit;

		// Token: 0x040012A2 RID: 4770
		private static readonly IntPtr NativeFieldInfoPtr__alternateMoveSpeed;

		// Token: 0x040012A3 RID: 4771
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveForward_Public_get_Hotkeys_0;

		// Token: 0x040012A4 RID: 4772
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveBack_Public_get_Hotkeys_0;

		// Token: 0x040012A5 RID: 4773
		private static readonly IntPtr NativeMethodInfoPtr_get_StrafeLeft_Public_get_Hotkeys_0;

		// Token: 0x040012A6 RID: 4774
		private static readonly IntPtr NativeMethodInfoPtr_get_StrafeRight_Public_get_Hotkeys_0;

		// Token: 0x040012A7 RID: 4775
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveUp_Public_get_Hotkeys_0;

		// Token: 0x040012A8 RID: 4776
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveDown_Public_get_Hotkeys_0;

		// Token: 0x040012A9 RID: 4777
		private static readonly IntPtr NativeMethodInfoPtr_get_Pan_Public_get_Hotkeys_0;

		// Token: 0x040012AA RID: 4778
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAround_Public_get_Hotkeys_0;

		// Token: 0x040012AB RID: 4779
		private static readonly IntPtr NativeMethodInfoPtr_get_Orbit_Public_get_Hotkeys_0;

		// Token: 0x040012AC RID: 4780
		private static readonly IntPtr NativeMethodInfoPtr_get_AlternateMoveSpeed_Public_get_Hotkeys_0;

		// Token: 0x040012AD RID: 4781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
