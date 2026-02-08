using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000B7 RID: 183
	public class PropertyMemberDescriptor : Object
	{
		// Token: 0x06000E47 RID: 3655 RVA: 0x0004EA84 File Offset: 0x0004CC84
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyMemberDescriptor()
		{
			Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "PropertyMemberDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr);
			PropertyMemberDescriptor.NativeFieldInfoPtr__PropertyInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, "<PropertyInfo>k__BackingField");
			PropertyMemberDescriptor.NativeFieldInfoPtr__AccessMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, "<AccessMode>k__BackingField");
			PropertyMemberDescriptor.NativeFieldInfoPtr__IsStatic_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, "<IsStatic>k__BackingField");
			PropertyMemberDescriptor.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, "<Name>k__BackingField");
			PropertyMemberDescriptor.NativeFieldInfoPtr_m_Getter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, "m_Getter");
			PropertyMemberDescriptor.NativeFieldInfoPtr_m_Setter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, "m_Setter");
			PropertyMemberDescriptor.NativeFieldInfoPtr_m_OptimizedGetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, "m_OptimizedGetter");
			PropertyMemberDescriptor.NativeFieldInfoPtr_m_OptimizedSetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, "m_OptimizedSetter");
			PropertyMemberDescriptor.NativeMethodInfoPtr_get_PropertyInfo_Public_get_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665839);
			PropertyMemberDescriptor.NativeMethodInfoPtr_set_PropertyInfo_Private_set_Void_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665840);
			PropertyMemberDescriptor.NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665841);
			PropertyMemberDescriptor.NativeMethodInfoPtr_set_AccessMode_Private_set_Void_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665842);
			PropertyMemberDescriptor.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665843);
			PropertyMemberDescriptor.NativeMethodInfoPtr_set_IsStatic_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665844);
			PropertyMemberDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665845);
			PropertyMemberDescriptor.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665846);
			PropertyMemberDescriptor.NativeMethodInfoPtr_get_CanRead_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665847);
			PropertyMemberDescriptor.NativeMethodInfoPtr_get_CanWrite_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665848);
			PropertyMemberDescriptor.NativeMethodInfoPtr_get_MemberAccess_Public_Virtual_Final_New_get_MemberDescriptorAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665857);
			PropertyMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_PropertyInfo_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665851);
			PropertyMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_PropertyInfo_InteropAccessMode_MethodInfo_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665852);
			PropertyMemberDescriptor.NativeMethodInfoPtr_TryCreateIfVisible_Public_Static_PropertyMemberDescriptor_PropertyInfo_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665849);
			PropertyMemberDescriptor.NativeMethodInfoPtr_TryCreate_Private_Static_PropertyMemberDescriptor_PropertyInfo_InteropAccessMode_MethodInfo_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665850);
			PropertyMemberDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665853);
			PropertyMemberDescriptor.NativeMethodInfoPtr_OptimizeGetter_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665854);
			PropertyMemberDescriptor.NativeMethodInfoPtr_OptimizeSetter_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665855);
			PropertyMemberDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Script_Object_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665856);
			PropertyMemberDescriptor.NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665858);
			PropertyMemberDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr, 100665859);
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x0004ECF8 File Offset: 0x0004CEF8
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x0004ED38 File Offset: 0x0004CF38
		public unsafe PropertyInfo PropertyInfo
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr_get_PropertyInfo_Public_get_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr_set_PropertyInfo_Private_set_Void_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x0004ED7C File Offset: 0x0004CF7C
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x0004EDBC File Offset: 0x0004CFBC
		public unsafe InteropAccessMode AccessMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InteropAccessMode>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 21383, RefRangeEnd = 21385, XrefRangeStart = 21383, XrefRangeEnd = 21385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr_set_AccessMode_Private_set_Void_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x0004EE00 File Offset: 0x0004D000
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x0004EE3C File Offset: 0x0004D03C
		public unsafe virtual bool IsStatic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr_set_IsStatic_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x0004EE7C File Offset: 0x0004D07C
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x0004EEB4 File Offset: 0x0004D0B4
		public unsafe virtual string Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21290, RefRangeEnd = 21298, XrefRangeStart = 21290, XrefRangeEnd = 21298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x0004EEF8 File Offset: 0x0004D0F8
		public unsafe bool CanRead
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36948, XrefRangeEnd = 36949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr_get_CanRead_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x0004EF34 File Offset: 0x0004D134
		public unsafe bool CanWrite
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36949, XrefRangeEnd = 36950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr_get_CanWrite_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x0004EF70 File Offset: 0x0004D170
		public unsafe virtual MemberDescriptorAccess MemberAccess
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36950, XrefRangeEnd = 36952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr_get_MemberAccess_Public_Virtual_Final_New_get_MemberDescriptorAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberDescriptorAccess>(intPtr3) : null;
			}
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x0004EFB0 File Offset: 0x0004D1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36952, XrefRangeEnd = 36964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyMemberDescriptor(PropertyInfo pi, InteropAccessMode accessMode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_PropertyInfo_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x0004F010 File Offset: 0x0004D210
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36985, RefRangeEnd = 36987, XrefRangeStart = 36964, XrefRangeEnd = 36985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyMemberDescriptor(PropertyInfo pi, InteropAccessMode accessMode, MethodInfo getter, MethodInfo setter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyMemberDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_PropertyInfo_InteropAccessMode_MethodInfo_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x0004F094 File Offset: 0x0004D294
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37015, RefRangeEnd = 37016, XrefRangeStart = 36987, XrefRangeEnd = 37015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyMemberDescriptor TryCreateIfVisible(PropertyInfo pi, InteropAccessMode accessMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr_TryCreateIfVisible_Public_Static_PropertyMemberDescriptor_PropertyInfo_InteropAccessMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyMemberDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x0004F0EC File Offset: 0x0004D2EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37023, RefRangeEnd = 37024, XrefRangeStart = 37016, XrefRangeEnd = 37023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyMemberDescriptor TryCreate(PropertyInfo pi, InteropAccessMode accessMode, MethodInfo getter, MethodInfo setter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr_TryCreate_Private_Static_PropertyMemberDescriptor_PropertyInfo_InteropAccessMode_MethodInfo_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyMemberDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x0004F168 File Offset: 0x0004D368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37024, XrefRangeEnd = 37051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynValue GetValue(Script script, Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_DynValue_Script_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0004F1CC File Offset: 0x0004D3CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 37113, RefRangeEnd = 37116, XrefRangeStart = 37051, XrefRangeEnd = 37113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptimizeGetter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr_OptimizeGetter_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x0004F200 File Offset: 0x0004D400
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 37204, RefRangeEnd = 37207, XrefRangeStart = 37116, XrefRangeEnd = 37204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptimizeSetter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr_OptimizeSetter_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0004F234 File Offset: 0x0004D434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37207, XrefRangeEnd = 37225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetValue(Script script, Object obj, DynValue v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Script_Object_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0004F29C File Offset: 0x0004D49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37225, XrefRangeEnd = 37227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x0004F2D0 File Offset: 0x0004D4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37227, XrefRangeEnd = 37278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PrepareForWiring(Table t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMemberDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x00006518 File Offset: 0x00004718
		public PropertyMemberDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x0004F314 File Offset: 0x0004D514
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x00006521 File Offset: 0x00004721
		public unsafe PropertyInfo _PropertyInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMemberDescriptor.NativeFieldInfoPtr__PropertyInfo_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMemberDescriptor.NativeFieldInfoPtr__PropertyInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x0004F344 File Offset: 0x0004D544
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x00006540 File Offset: 0x00004740
		public unsafe InteropAccessMode _AccessMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMemberDescriptor.NativeFieldInfoPtr__AccessMode_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteropAccessMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMemberDescriptor.NativeFieldInfoPtr__AccessMode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x0004F374 File Offset: 0x0004D574
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x0000655F File Offset: 0x0000475F
		public unsafe bool _IsStatic_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMemberDescriptor.NativeFieldInfoPtr__IsStatic_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMemberDescriptor.NativeFieldInfoPtr__IsStatic_k__BackingField)) = value;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x0004F39C File Offset: 0x0004D59C
		// (set) Token: 0x06000E65 RID: 3685 RVA: 0x0000657A File Offset: 0x0000477A
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMemberDescriptor.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMemberDescriptor.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x0004F3C4 File Offset: 0x0004D5C4
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x00006599 File Offset: 0x00004799
		public unsafe MethodInfo m_Getter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMemberDescriptor.NativeFieldInfoPtr_m_Getter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMemberDescriptor.NativeFieldInfoPtr_m_Getter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x0004F3F4 File Offset: 0x0004D5F4
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x000065B8 File Offset: 0x000047B8
		public unsafe MethodInfo m_Setter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMemberDescriptor.NativeFieldInfoPtr_m_Setter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMemberDescriptor.NativeFieldInfoPtr_m_Setter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x0004F424 File Offset: 0x0004D624
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x000065D7 File Offset: 0x000047D7
		public unsafe Func<Object, Object> m_OptimizedGetter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMemberDescriptor.NativeFieldInfoPtr_m_OptimizedGetter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMemberDescriptor.NativeFieldInfoPtr_m_OptimizedGetter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x0004F454 File Offset: 0x0004D654
		// (set) Token: 0x06000E6D RID: 3693 RVA: 0x000065F6 File Offset: 0x000047F6
		public unsafe Action<Object, Object> m_OptimizedSetter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMemberDescriptor.NativeFieldInfoPtr_m_OptimizedSetter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyMemberDescriptor.NativeFieldInfoPtr_m_OptimizedSetter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeFieldInfoPtr__PropertyInfo_k__BackingField;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeFieldInfoPtr__AccessMode_k__BackingField;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeFieldInfoPtr__IsStatic_k__BackingField;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeFieldInfoPtr_m_Getter;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeFieldInfoPtr_m_Setter;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeFieldInfoPtr_m_OptimizedGetter;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeFieldInfoPtr_m_OptimizedSetter;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyInfo_Public_get_PropertyInfo_0;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeMethodInfoPtr_set_PropertyInfo_Private_set_Void_PropertyInfo_0;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeMethodInfoPtr_set_AccessMode_Private_set_Void_InteropAccessMode_0;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeMethodInfoPtr_set_IsStatic_Private_set_Void_Boolean_0;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Private_set_Void_String_0;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_get_Boolean_0;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_get_Boolean_0;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberAccess_Public_Virtual_Final_New_get_MemberDescriptorAccess_0;

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PropertyInfo_InteropAccessMode_0;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PropertyInfo_InteropAccessMode_MethodInfo_MethodInfo_0;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeMethodInfoPtr_TryCreateIfVisible_Public_Static_PropertyMemberDescriptor_PropertyInfo_InteropAccessMode_0;

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeMethodInfoPtr_TryCreate_Private_Static_PropertyMemberDescriptor_PropertyInfo_InteropAccessMode_MethodInfo_MethodInfo_0;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_DynValue_Script_Object_0;

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeMethodInfoPtr_OptimizeGetter_Internal_Void_0;

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeMethodInfoPtr_OptimizeSetter_Internal_Void_0;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Script_Object_DynValue_0;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0;
	}
}
