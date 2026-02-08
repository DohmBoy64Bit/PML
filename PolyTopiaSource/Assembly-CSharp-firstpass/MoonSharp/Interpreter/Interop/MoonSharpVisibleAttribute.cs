using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x02000099 RID: 153
	public sealed class MoonSharpVisibleAttribute : Attribute
	{
		// Token: 0x06000C84 RID: 3204 RVA: 0x00046CA0 File Offset: 0x00044EA0
		// Note: this type is marked as 'beforefieldinit'.
		static MoonSharpVisibleAttribute()
		{
			Il2CppClassPointerStore<MoonSharpVisibleAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "MoonSharpVisibleAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoonSharpVisibleAttribute>.NativeClassPtr);
			MoonSharpVisibleAttribute.NativeFieldInfoPtr__Visible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoonSharpVisibleAttribute>.NativeClassPtr, "<Visible>k__BackingField");
			MoonSharpVisibleAttribute.NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpVisibleAttribute>.NativeClassPtr, 100665460);
			MoonSharpVisibleAttribute.NativeMethodInfoPtr_set_Visible_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpVisibleAttribute>.NativeClassPtr, 100665461);
			MoonSharpVisibleAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoonSharpVisibleAttribute>.NativeClassPtr, 100665462);
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x00046D20 File Offset: 0x00044F20
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x00046D5C File Offset: 0x00044F5C
		public unsafe bool Visible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpVisibleAttribute.NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20587, RefRangeEnd = 20588, XrefRangeStart = 20587, XrefRangeEnd = 20588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpVisibleAttribute.NativeMethodInfoPtr_set_Visible_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00046D9C File Offset: 0x00044F9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20589, RefRangeEnd = 20591, XrefRangeStart = 20589, XrefRangeEnd = 20591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoonSharpVisibleAttribute(bool visible)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoonSharpVisibleAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoonSharpVisibleAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00005B3D File Offset: 0x00003D3D
		public MoonSharpVisibleAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x00046DE4 File Offset: 0x00044FE4
		// (set) Token: 0x06000C8A RID: 3210 RVA: 0x00005B46 File Offset: 0x00003D46
		public unsafe bool _Visible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonSharpVisibleAttribute.NativeFieldInfoPtr__Visible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoonSharpVisibleAttribute.NativeFieldInfoPtr__Visible_k__BackingField)) = value;
			}
		}

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeFieldInfoPtr__Visible_k__BackingField;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_set_Visible_Private_set_Void_Boolean_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
