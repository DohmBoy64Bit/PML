using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000B3 RID: 179
	public class FieldMemberDescriptor : Object
	{
		// Token: 0x06000DBE RID: 3518 RVA: 0x0004C75C File Offset: 0x0004A95C
		// Note: this type is marked as 'beforefieldinit'.
		static FieldMemberDescriptor()
		{
			Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "FieldMemberDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr);
			FieldMemberDescriptor.NativeFieldInfoPtr__FieldInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, "<FieldInfo>k__BackingField");
			FieldMemberDescriptor.NativeFieldInfoPtr__AccessMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, "<AccessMode>k__BackingField");
			FieldMemberDescriptor.NativeFieldInfoPtr__IsStatic_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, "<IsStatic>k__BackingField");
			FieldMemberDescriptor.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, "<Name>k__BackingField");
			FieldMemberDescriptor.NativeFieldInfoPtr__IsConst_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, "<IsConst>k__BackingField");
			FieldMemberDescriptor.NativeFieldInfoPtr__IsReadonly_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, "<IsReadonly>k__BackingField");
			FieldMemberDescriptor.NativeFieldInfoPtr_m_ConstValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, "m_ConstValue");
			FieldMemberDescriptor.NativeFieldInfoPtr_m_OptimizedGetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, "m_OptimizedGetter");
			FieldMemberDescriptor.NativeMethodInfoPtr_get_FieldInfo_Public_get_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665752);
			FieldMemberDescriptor.NativeMethodInfoPtr_set_FieldInfo_Private_set_Void_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665753);
			FieldMemberDescriptor.NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665754);
			FieldMemberDescriptor.NativeMethodInfoPtr_set_AccessMode_Private_set_Void_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665755);
			FieldMemberDescriptor.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665756);
			FieldMemberDescriptor.NativeMethodInfoPtr_set_IsStatic_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665757);
			FieldMemberDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665758);
			FieldMemberDescriptor.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665759);
			FieldMemberDescriptor.NativeMethodInfoPtr_get_IsConst_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665760);
			FieldMemberDescriptor.NativeMethodInfoPtr_set_IsConst_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665761);
			FieldMemberDescriptor.NativeMethodInfoPtr_get_IsReadonly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665762);
			FieldMemberDescriptor.NativeMethodInfoPtr_set_IsReadonly_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665763);
			FieldMemberDescriptor.NativeMethodInfoPtr_get_MemberAccess_Public_Virtual_Final_New_get_MemberDescriptorAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665769);
			FieldMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665765);
			FieldMemberDescriptor.NativeMethodInfoPtr_TryCreateIfVisible_Public_Static_FieldMemberDescriptor_FieldInfo_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665764);
			FieldMemberDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_DynValue_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665766);
			FieldMemberDescriptor.NativeMethodInfoPtr_OptimizeGetter_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665767);
			FieldMemberDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Script_Object_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665768);
			FieldMemberDescriptor.NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665770);
			FieldMemberDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr, 100665771);
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x0004C9BC File Offset: 0x0004ABBC
		// (set) Token: 0x06000DC0 RID: 3520 RVA: 0x0004C9FC File Offset: 0x0004ABFC
		public unsafe FieldInfo FieldInfo
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr_get_FieldInfo_Public_get_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr_set_FieldInfo_Private_set_Void_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x0004CA40 File Offset: 0x0004AC40
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x0004CA80 File Offset: 0x0004AC80
		public unsafe InteropAccessMode AccessMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr_set_AccessMode_Private_set_Void_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x0004CAC4 File Offset: 0x0004ACC4
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x0004CB00 File Offset: 0x0004AD00
		public unsafe virtual bool IsStatic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr_set_IsStatic_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x0004CB40 File Offset: 0x0004AD40
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x0004CB78 File Offset: 0x0004AD78
		public unsafe virtual string Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x0004CBBC File Offset: 0x0004ADBC
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x0004CBF8 File Offset: 0x0004ADF8
		public unsafe bool IsConst
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr_get_IsConst_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr_set_IsConst_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x0004CC38 File Offset: 0x0004AE38
		// (set) Token: 0x06000DCA RID: 3530 RVA: 0x0004CC74 File Offset: 0x0004AE74
		public unsafe bool IsReadonly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr_get_IsReadonly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr_set_IsReadonly_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x0004CCB4 File Offset: 0x0004AEB4
		public unsafe virtual MemberDescriptorAccess MemberAccess
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr_get_MemberAccess_Public_Virtual_Final_New_get_MemberDescriptorAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberDescriptorAccess>(intPtr3) : null;
			}
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0004CCF4 File Offset: 0x0004AEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35637, XrefRangeEnd = 35656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldMemberDescriptor(FieldInfo fi, InteropAccessMode accessMode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldMemberDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x0004CD54 File Offset: 0x0004AF54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35662, RefRangeEnd = 35663, XrefRangeStart = 35656, XrefRangeEnd = 35662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FieldMemberDescriptor TryCreateIfVisible(FieldInfo fi, InteropAccessMode accessMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr_TryCreateIfVisible_Public_Static_FieldMemberDescriptor_FieldInfo_InteropAccessMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldMemberDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x0004CDAC File Offset: 0x0004AFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35663, XrefRangeEnd = 35669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_DynValue_Script_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0004CE10 File Offset: 0x0004B010
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 35729, RefRangeEnd = 35732, XrefRangeStart = 35669, XrefRangeEnd = 35729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptimizeGetter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr_OptimizeGetter_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x0004CE44 File Offset: 0x0004B044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35732, XrefRangeEnd = 35742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Script_Object_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0004CEAC File Offset: 0x0004B0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35742, XrefRangeEnd = 35743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0004CEE0 File Offset: 0x0004B0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35743, XrefRangeEnd = 35802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PrepareForWiring(Table t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldMemberDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00006197 File Offset: 0x00004397
		public FieldMemberDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x0004CF24 File Offset: 0x0004B124
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x000061A0 File Offset: 0x000043A0
		public unsafe FieldInfo _FieldInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMemberDescriptor.NativeFieldInfoPtr__FieldInfo_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMemberDescriptor.NativeFieldInfoPtr__FieldInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x0004CF54 File Offset: 0x0004B154
		// (set) Token: 0x06000DD7 RID: 3543 RVA: 0x000061BF File Offset: 0x000043BF
		public unsafe InteropAccessMode _AccessMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMemberDescriptor.NativeFieldInfoPtr__AccessMode_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteropAccessMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMemberDescriptor.NativeFieldInfoPtr__AccessMode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x0004CF84 File Offset: 0x0004B184
		// (set) Token: 0x06000DD9 RID: 3545 RVA: 0x000061DE File Offset: 0x000043DE
		public unsafe bool _IsStatic_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMemberDescriptor.NativeFieldInfoPtr__IsStatic_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMemberDescriptor.NativeFieldInfoPtr__IsStatic_k__BackingField)) = value;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x0004CFAC File Offset: 0x0004B1AC
		// (set) Token: 0x06000DDB RID: 3547 RVA: 0x000061F9 File Offset: 0x000043F9
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMemberDescriptor.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMemberDescriptor.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x0004CFD4 File Offset: 0x0004B1D4
		// (set) Token: 0x06000DDD RID: 3549 RVA: 0x00006218 File Offset: 0x00004418
		public unsafe bool _IsConst_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMemberDescriptor.NativeFieldInfoPtr__IsConst_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMemberDescriptor.NativeFieldInfoPtr__IsConst_k__BackingField)) = value;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x0004CFFC File Offset: 0x0004B1FC
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x00006233 File Offset: 0x00004433
		public unsafe bool _IsReadonly_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMemberDescriptor.NativeFieldInfoPtr__IsReadonly_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMemberDescriptor.NativeFieldInfoPtr__IsReadonly_k__BackingField)) = value;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x0004D024 File Offset: 0x0004B224
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x0000624E File Offset: 0x0000444E
		public unsafe Object m_ConstValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMemberDescriptor.NativeFieldInfoPtr_m_ConstValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMemberDescriptor.NativeFieldInfoPtr_m_ConstValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x0004D054 File Offset: 0x0004B254
		// (set) Token: 0x06000DE3 RID: 3555 RVA: 0x0000626D File Offset: 0x0000446D
		public unsafe Func<Object, Object> m_OptimizedGetter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMemberDescriptor.NativeFieldInfoPtr_m_OptimizedGetter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldMemberDescriptor.NativeFieldInfoPtr_m_OptimizedGetter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeFieldInfoPtr__FieldInfo_k__BackingField;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeFieldInfoPtr__AccessMode_k__BackingField;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeFieldInfoPtr__IsStatic_k__BackingField;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeFieldInfoPtr__IsConst_k__BackingField;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeFieldInfoPtr__IsReadonly_k__BackingField;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeFieldInfoPtr_m_ConstValue;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeFieldInfoPtr_m_OptimizedGetter;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_get_FieldInfo_Public_get_FieldInfo_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_set_FieldInfo_Private_set_Void_FieldInfo_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_set_AccessMode_Private_set_Void_InteropAccessMode_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_set_IsStatic_Private_set_Void_Boolean_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Private_set_Void_String_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConst_Public_get_Boolean_0;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr_set_IsConst_Private_set_Void_Boolean_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadonly_Public_get_Boolean_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr_set_IsReadonly_Private_set_Void_Boolean_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberAccess_Public_Virtual_Final_New_get_MemberDescriptorAccess_0;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_InteropAccessMode_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_TryCreateIfVisible_Public_Static_FieldMemberDescriptor_FieldInfo_InteropAccessMode_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_DynValue_Script_Object_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_OptimizeGetter_Internal_Void_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Script_Object_DynValue_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_MoonSharp_Interpreter_Interop_BasicDescriptors_IOptimizableDescriptor_Optimize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0;
	}
}
