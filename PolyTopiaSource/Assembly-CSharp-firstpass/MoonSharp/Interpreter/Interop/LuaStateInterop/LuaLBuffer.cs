using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace MoonSharp.Interpreter.Interop.LuaStateInterop
{
	// Token: 0x020000CB RID: 203
	public class LuaLBuffer : Object
	{
		// Token: 0x06000FDB RID: 4059 RVA: 0x00055EE4 File Offset: 0x000540E4
		// Note: this type is marked as 'beforefieldinit'.
		static LuaLBuffer()
		{
			Il2CppClassPointerStore<LuaLBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.LuaStateInterop", "LuaLBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuaLBuffer>.NativeClassPtr);
			LuaLBuffer.NativeFieldInfoPtr__StringBuilder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaLBuffer>.NativeClassPtr, "<StringBuilder>k__BackingField");
			LuaLBuffer.NativeFieldInfoPtr__LuaState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaLBuffer>.NativeClassPtr, "<LuaState>k__BackingField");
			LuaLBuffer.NativeMethodInfoPtr_get_StringBuilder_Public_get_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaLBuffer>.NativeClassPtr, 100666155);
			LuaLBuffer.NativeMethodInfoPtr_set_StringBuilder_Private_set_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaLBuffer>.NativeClassPtr, 100666156);
			LuaLBuffer.NativeMethodInfoPtr_get_LuaState_Public_get_LuaState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaLBuffer>.NativeClassPtr, 100666157);
			LuaLBuffer.NativeMethodInfoPtr_set_LuaState_Private_set_Void_LuaState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaLBuffer>.NativeClassPtr, 100666158);
			LuaLBuffer.NativeMethodInfoPtr__ctor_Public_Void_LuaState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaLBuffer>.NativeClassPtr, 100666159);
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00055FA0 File Offset: 0x000541A0
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x00055FE0 File Offset: 0x000541E0
		public unsafe StringBuilder StringBuilder
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaLBuffer.NativeMethodInfoPtr_get_StringBuilder_Public_get_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaLBuffer.NativeMethodInfoPtr_set_StringBuilder_Private_set_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x00056024 File Offset: 0x00054224
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x00056064 File Offset: 0x00054264
		public unsafe LuaState LuaState
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaLBuffer.NativeMethodInfoPtr_get_LuaState_Public_get_LuaState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaState>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21274, RefRangeEnd = 21282, XrefRangeStart = 21274, XrefRangeEnd = 21282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaLBuffer.NativeMethodInfoPtr_set_LuaState_Private_set_Void_LuaState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x000560A8 File Offset: 0x000542A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40334, RefRangeEnd = 40336, XrefRangeStart = 40327, XrefRangeEnd = 40334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LuaLBuffer(LuaState l)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LuaLBuffer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaLBuffer.NativeMethodInfoPtr__ctor_Public_Void_LuaState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00006B48 File Offset: 0x00004D48
		public LuaLBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x000560F4 File Offset: 0x000542F4
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x00006B51 File Offset: 0x00004D51
		public unsafe StringBuilder _StringBuilder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LuaLBuffer.NativeFieldInfoPtr__StringBuilder_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LuaLBuffer.NativeFieldInfoPtr__StringBuilder_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00056124 File Offset: 0x00054324
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x00006B70 File Offset: 0x00004D70
		public unsafe LuaState _LuaState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LuaLBuffer.NativeFieldInfoPtr__LuaState_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LuaLBuffer.NativeFieldInfoPtr__LuaState_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeFieldInfoPtr__StringBuilder_k__BackingField;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeFieldInfoPtr__LuaState_k__BackingField;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr_get_StringBuilder_Public_get_StringBuilder_0;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr_set_StringBuilder_Private_set_Void_StringBuilder_0;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeMethodInfoPtr_get_LuaState_Public_get_LuaState_0;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeMethodInfoPtr_set_LuaState_Private_set_Void_LuaState_0;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LuaState_0;
	}
}
