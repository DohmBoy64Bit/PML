using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000049 RID: 73
	public sealed class MoonSharpUserDataAttribute : Attribute
	{
		// Token: 0x0600086B RID: 2155 RVA: 0x000368D8 File Offset: 0x00034AD8
		// Note: this type is marked as 'beforefieldinit'.
		static MoonSharpUserDataAttribute()
		{
			Il2CppClassPointerStore<MoonSharpUserDataAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "MoonSharpUserDataAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoonSharpUserDataAttribute>.NativeClassPtr);
			MoonSharpUserDataAttribute.NativeFieldInfoPtr__AccessMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoonSharpUserDataAttribute>.NativeClassPtr, "<AccessMode>k__BackingField");
			MoonSharpUserDataAttribute.NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpUserDataAttribute>.NativeClassPtr, 100664895);
			MoonSharpUserDataAttribute.NativeMethodInfoPtr_set_AccessMode_Public_set_Void_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpUserDataAttribute>.NativeClassPtr, 100664896);
			MoonSharpUserDataAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpUserDataAttribute>.NativeClassPtr, 100664897);
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x00036958 File Offset: 0x00034B58
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x00036998 File Offset: 0x00034B98
		public unsafe InteropAccessMode AccessMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpUserDataAttribute.NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InteropAccessMode>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 3, RefRangeEnd = 6, XrefRangeStart = 3, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpUserDataAttribute.NativeMethodInfoPtr_set_AccessMode_Public_set_Void_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000369DC File Offset: 0x00034BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25910, XrefRangeEnd = 25911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoonSharpUserDataAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoonSharpUserDataAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpUserDataAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x000041F1 File Offset: 0x000023F1
		public MoonSharpUserDataAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x00036A18 File Offset: 0x00034C18
		// (set) Token: 0x06000871 RID: 2161 RVA: 0x000041FA File Offset: 0x000023FA
		public unsafe InteropAccessMode _AccessMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonSharpUserDataAttribute.NativeFieldInfoPtr__AccessMode_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteropAccessMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonSharpUserDataAttribute.NativeFieldInfoPtr__AccessMode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeFieldInfoPtr__AccessMode_k__BackingField;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr_set_AccessMode_Public_set_Void_InteropAccessMode_0;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
