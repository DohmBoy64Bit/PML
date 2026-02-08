using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200012C RID: 300
	public static class SpriteEx : global::Il2CppSystem.Object
	{
		// Token: 0x06001B9B RID: 7067 RVA: 0x0008CE2C File Offset: 0x0008B02C
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteEx()
		{
			Il2CppClassPointerStore<SpriteEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SpriteEx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteEx>.NativeClassPtr);
			SpriteEx.NativeMethodInfoPtr_GetWorldVerts_Public_Static_List_1_Vector3_Sprite_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteEx>.NativeClassPtr, 100667435);
			SpriteEx.NativeMethodInfoPtr_GetModelVerts_Public_Static_List_1_Vector3_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteEx>.NativeClassPtr, 100667436);
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x0008CE84 File Offset: 0x0008B084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77682, RefRangeEnd = 77683, XrefRangeStart = 77655, XrefRangeEnd = 77682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> GetWorldVerts(this Sprite sprite, Transform spriteTransform)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteEx.NativeMethodInfoPtr_GetWorldVerts_Public_Static_List_1_Vector3_Sprite_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x0008CEDC File Offset: 0x0008B0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77683, XrefRangeEnd = 77695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> GetModelVerts(this Sprite sprite)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteEx.NativeMethodInfoPtr_GetModelVerts_Public_Static_List_1_Vector3_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
			}
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x0000BD79 File Offset: 0x00009F79
		public SpriteEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldVerts_Public_Static_List_1_Vector3_Sprite_Transform_0;

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeMethodInfoPtr_GetModelVerts_Public_Static_List_1_Vector3_Sprite_0;
	}
}
