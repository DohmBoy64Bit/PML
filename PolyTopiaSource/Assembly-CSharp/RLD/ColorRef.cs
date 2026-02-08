using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200011C RID: 284
	public class ColorRef : global::Il2CppSystem.Object
	{
		// Token: 0x06001AE6 RID: 6886 RVA: 0x00089A8C File Offset: 0x00087C8C
		// Note: this type is marked as 'beforefieldinit'.
		static ColorRef()
		{
			Il2CppClassPointerStore<ColorRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ColorRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorRef>.NativeClassPtr);
			ColorRef.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorRef>.NativeClassPtr, "_value");
			ColorRef.NativeMethodInfoPtr_get_Value_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorRef>.NativeClassPtr, 100667299);
			ColorRef.NativeMethodInfoPtr_set_Value_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorRef>.NativeClassPtr, 100667300);
			ColorRef.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorRef>.NativeClassPtr, 100667301);
			ColorRef.NativeMethodInfoPtr__ctor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorRef>.NativeClassPtr, 100667302);
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x00089B20 File Offset: 0x00087D20
		// (set) Token: 0x06001AE8 RID: 6888 RVA: 0x00089B60 File Offset: 0x00087D60
		public unsafe Color Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorRef.NativeMethodInfoPtr_get_Value_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorRef.NativeMethodInfoPtr_set_Value_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x00089BA4 File Offset: 0x00087DA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76032, RefRangeEnd = 76033, XrefRangeStart = 76031, XrefRangeEnd = 76032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorRef()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorRef>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorRef.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x00089BE0 File Offset: 0x00087DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76033, XrefRangeEnd = 76034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorRef(Color color)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorRef>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorRef.NativeMethodInfoPtr__ctor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x0000BB96 File Offset: 0x00009D96
		public ColorRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x00089C2C File Offset: 0x00087E2C
		// (set) Token: 0x06001AED RID: 6893 RVA: 0x0000BB9F File Offset: 0x00009D9F
		public unsafe Color _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorRef.NativeFieldInfoPtr__value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorRef.NativeFieldInfoPtr__value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001479 RID: 5241
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x0400147A RID: 5242
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Color_0;

		// Token: 0x0400147B RID: 5243
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Color_0;

		// Token: 0x0400147C RID: 5244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400147D RID: 5245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_0;
	}
}
