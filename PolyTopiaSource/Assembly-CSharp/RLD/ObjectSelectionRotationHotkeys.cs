using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace RLD
{
	// Token: 0x02000221 RID: 545
	[Serializable]
	public class ObjectSelectionRotationHotkeys : Settings
	{
		// Token: 0x06002A90 RID: 10896 RVA: 0x000C9A14 File Offset: 0x000C7C14
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectionRotationHotkeys()
		{
			Il2CppClassPointerStore<ObjectSelectionRotationHotkeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectionRotationHotkeys");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSelectionRotationHotkeys>.NativeClassPtr);
			ObjectSelectionRotationHotkeys.NativeFieldInfoPtr__rotateAroundX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionRotationHotkeys>.NativeClassPtr, "_rotateAroundX");
			ObjectSelectionRotationHotkeys.NativeFieldInfoPtr__rotateAroundY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionRotationHotkeys>.NativeClassPtr, "_rotateAroundY");
			ObjectSelectionRotationHotkeys.NativeFieldInfoPtr__rotateAroundZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionRotationHotkeys>.NativeClassPtr, "_rotateAroundZ");
			ObjectSelectionRotationHotkeys.NativeFieldInfoPtr__setRotationToIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectionRotationHotkeys>.NativeClassPtr, "_setRotationToIdentity");
			ObjectSelectionRotationHotkeys.NativeMethodInfoPtr_get_RotateAroundX_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionRotationHotkeys>.NativeClassPtr, 100669780);
			ObjectSelectionRotationHotkeys.NativeMethodInfoPtr_get_RotateAroundY_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionRotationHotkeys>.NativeClassPtr, 100669781);
			ObjectSelectionRotationHotkeys.NativeMethodInfoPtr_get_RotateAroundZ_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionRotationHotkeys>.NativeClassPtr, 100669782);
			ObjectSelectionRotationHotkeys.NativeMethodInfoPtr_get_SetRotationToIdentity_Public_get_Hotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionRotationHotkeys>.NativeClassPtr, 100669783);
			ObjectSelectionRotationHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectionRotationHotkeys>.NativeClassPtr, 100669784);
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06002A91 RID: 10897 RVA: 0x000C9AF8 File Offset: 0x000C7CF8
		public unsafe Hotkeys RotateAroundX
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionRotationHotkeys.NativeMethodInfoPtr_get_RotateAroundX_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06002A92 RID: 10898 RVA: 0x000C9B38 File Offset: 0x000C7D38
		public unsafe Hotkeys RotateAroundY
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionRotationHotkeys.NativeMethodInfoPtr_get_RotateAroundY_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06002A93 RID: 10899 RVA: 0x000C9B78 File Offset: 0x000C7D78
		public unsafe Hotkeys RotateAroundZ
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionRotationHotkeys.NativeMethodInfoPtr_get_RotateAroundZ_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06002A94 RID: 10900 RVA: 0x000C9BB8 File Offset: 0x000C7DB8
		public unsafe Hotkeys SetRotationToIdentity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionRotationHotkeys.NativeMethodInfoPtr_get_SetRotationToIdentity_Public_get_Hotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x000C9BF8 File Offset: 0x000C7DF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93575, RefRangeEnd = 93576, XrefRangeStart = 93544, XrefRangeEnd = 93575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionRotationHotkeys()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectionRotationHotkeys>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectionRotationHotkeys.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x00010D05 File Offset: 0x0000EF05
		public ObjectSelectionRotationHotkeys(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06002A97 RID: 10903 RVA: 0x000C9C34 File Offset: 0x000C7E34
		// (set) Token: 0x06002A98 RID: 10904 RVA: 0x00010D0E File Offset: 0x0000EF0E
		public unsafe Hotkeys _rotateAroundX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionRotationHotkeys.NativeFieldInfoPtr__rotateAroundX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionRotationHotkeys.NativeFieldInfoPtr__rotateAroundX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06002A99 RID: 10905 RVA: 0x000C9C64 File Offset: 0x000C7E64
		// (set) Token: 0x06002A9A RID: 10906 RVA: 0x00010D2D File Offset: 0x0000EF2D
		public unsafe Hotkeys _rotateAroundY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionRotationHotkeys.NativeFieldInfoPtr__rotateAroundY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionRotationHotkeys.NativeFieldInfoPtr__rotateAroundY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06002A9B RID: 10907 RVA: 0x000C9C94 File Offset: 0x000C7E94
		// (set) Token: 0x06002A9C RID: 10908 RVA: 0x00010D4C File Offset: 0x0000EF4C
		public unsafe Hotkeys _rotateAroundZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionRotationHotkeys.NativeFieldInfoPtr__rotateAroundZ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionRotationHotkeys.NativeFieldInfoPtr__rotateAroundZ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06002A9D RID: 10909 RVA: 0x000C9CC4 File Offset: 0x000C7EC4
		// (set) Token: 0x06002A9E RID: 10910 RVA: 0x00010D6B File Offset: 0x0000EF6B
		public unsafe Hotkeys _setRotationToIdentity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionRotationHotkeys.NativeFieldInfoPtr__setRotationToIdentity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectionRotationHotkeys.NativeFieldInfoPtr__setRotationToIdentity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020E9 RID: 8425
		private static readonly IntPtr NativeFieldInfoPtr__rotateAroundX;

		// Token: 0x040020EA RID: 8426
		private static readonly IntPtr NativeFieldInfoPtr__rotateAroundY;

		// Token: 0x040020EB RID: 8427
		private static readonly IntPtr NativeFieldInfoPtr__rotateAroundZ;

		// Token: 0x040020EC RID: 8428
		private static readonly IntPtr NativeFieldInfoPtr__setRotationToIdentity;

		// Token: 0x040020ED RID: 8429
		private static readonly IntPtr NativeMethodInfoPtr_get_RotateAroundX_Public_get_Hotkeys_0;

		// Token: 0x040020EE RID: 8430
		private static readonly IntPtr NativeMethodInfoPtr_get_RotateAroundY_Public_get_Hotkeys_0;

		// Token: 0x040020EF RID: 8431
		private static readonly IntPtr NativeMethodInfoPtr_get_RotateAroundZ_Public_get_Hotkeys_0;

		// Token: 0x040020F0 RID: 8432
		private static readonly IntPtr NativeMethodInfoPtr_get_SetRotationToIdentity_Public_get_Hotkeys_0;

		// Token: 0x040020F1 RID: 8433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
