using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000008 RID: 8
public class DefaultCamera : MonoBehaviour
{
	// Token: 0x06000031 RID: 49 RVA: 0x000219AC File Offset: 0x0001FBAC
	// Note: this type is marked as 'beforefieldinit'.
	static DefaultCamera()
	{
		Il2CppClassPointerStore<DefaultCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DefaultCamera");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultCamera>.NativeClassPtr);
		DefaultCamera.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultCamera>.NativeClassPtr, "cam");
		DefaultCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCamera>.NativeClassPtr, 100663321);
		DefaultCamera.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCamera>.NativeClassPtr, 100663319);
		DefaultCamera.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCamera>.NativeClassPtr, 100663320);
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00021A2C File Offset: 0x0001FC2C
	[CallerCount(61)]
	[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DefaultCamera()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultCamera>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00021A68 File Offset: 0x0001FC68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55694, XrefRangeEnd = 55698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultCamera.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00021A9C File Offset: 0x0001FC9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55698, XrefRangeEnd = 55708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultCamera.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002146 File Offset: 0x00000346
	public DefaultCamera(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000036 RID: 54 RVA: 0x00021AD0 File Offset: 0x0001FCD0
	// (set) Token: 0x06000037 RID: 55 RVA: 0x0000214F File Offset: 0x0000034F
	public unsafe Camera cam
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultCamera.NativeFieldInfoPtr_cam);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultCamera.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400001E RID: 30
	private static readonly IntPtr NativeFieldInfoPtr_cam;

	// Token: 0x0400001F RID: 31
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000020 RID: 32
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000021 RID: 33
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
}
