using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000003 RID: 3
public static class EmptySprite : global::Il2CppSystem.Object
{
	// Token: 0x0600000A RID: 10 RVA: 0x00021108 File Offset: 0x0001F308
	// Note: this type is marked as 'beforefieldinit'.
	static EmptySprite()
	{
		Il2CppClassPointerStore<EmptySprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "EmptySprite");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmptySprite>.NativeClassPtr);
		EmptySprite.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptySprite>.NativeClassPtr, "instance");
		EmptySprite.NativeMethodInfoPtr_Get_Public_Static_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptySprite>.NativeClassPtr, 100663300);
		EmptySprite.NativeMethodInfoPtr_IsEmptySprite_Public_Static_Boolean_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptySprite>.NativeClassPtr, 100663301);
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00021174 File Offset: 0x0001F374
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 55663, RefRangeEnd = 55666, XrefRangeStart = 55648, XrefRangeEnd = 55663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite Get()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptySprite.NativeMethodInfoPtr_Get_Public_Static_Sprite_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000211A8 File Offset: 0x0001F3A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55666, XrefRangeEnd = 55685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsEmptySprite(Sprite s)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptySprite.NativeMethodInfoPtr_IsEmptySprite_Public_Static_Boolean_Sprite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002097 File Offset: 0x00000297
	public EmptySprite(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600000E RID: 14 RVA: 0x000211EC File Offset: 0x0001F3EC
	// (set) Token: 0x0600000F RID: 15 RVA: 0x000020A0 File Offset: 0x000002A0
	public unsafe static Sprite instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(EmptySprite.NativeFieldInfoPtr_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(EmptySprite.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000006 RID: 6
	private static readonly IntPtr NativeFieldInfoPtr_instance;

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Sprite_0;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeMethodInfoPtr_IsEmptySprite_Public_Static_Boolean_Sprite_0;
}
