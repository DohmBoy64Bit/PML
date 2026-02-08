using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
	// Token: 0x020000DA RID: 218
	public sealed class ParameterDescriptor : Object
	{
		// Token: 0x060010BA RID: 4282 RVA: 0x000598F4 File Offset: 0x00057AF4
		// Note: this type is marked as 'beforefieldinit'.
		static ParameterDescriptor()
		{
			Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.BasicDescriptors", "ParameterDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr);
			ParameterDescriptor.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, "<Name>k__BackingField");
			ParameterDescriptor.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, "<Type>k__BackingField");
			ParameterDescriptor.NativeFieldInfoPtr__HasDefaultValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, "<HasDefaultValue>k__BackingField");
			ParameterDescriptor.NativeFieldInfoPtr__DefaultValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, "<DefaultValue>k__BackingField");
			ParameterDescriptor.NativeFieldInfoPtr__IsOut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, "<IsOut>k__BackingField");
			ParameterDescriptor.NativeFieldInfoPtr__IsRef_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, "<IsRef>k__BackingField");
			ParameterDescriptor.NativeFieldInfoPtr__IsVarArgs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, "<IsVarArgs>k__BackingField");
			ParameterDescriptor.NativeFieldInfoPtr_m_OriginalType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, "m_OriginalType");
			ParameterDescriptor.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666288);
			ParameterDescriptor.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666289);
			ParameterDescriptor.NativeMethodInfoPtr_get_Type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666290);
			ParameterDescriptor.NativeMethodInfoPtr_set_Type_Private_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666291);
			ParameterDescriptor.NativeMethodInfoPtr_get_HasDefaultValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666292);
			ParameterDescriptor.NativeMethodInfoPtr_set_HasDefaultValue_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666293);
			ParameterDescriptor.NativeMethodInfoPtr_get_DefaultValue_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666294);
			ParameterDescriptor.NativeMethodInfoPtr_set_DefaultValue_Private_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666295);
			ParameterDescriptor.NativeMethodInfoPtr_get_IsOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666296);
			ParameterDescriptor.NativeMethodInfoPtr_set_IsOut_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666297);
			ParameterDescriptor.NativeMethodInfoPtr_get_IsRef_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666298);
			ParameterDescriptor.NativeMethodInfoPtr_set_IsRef_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666299);
			ParameterDescriptor.NativeMethodInfoPtr_get_IsVarArgs_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666300);
			ParameterDescriptor.NativeMethodInfoPtr_set_IsVarArgs_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666301);
			ParameterDescriptor.NativeMethodInfoPtr_get_HasBeenRestricted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666302);
			ParameterDescriptor.NativeMethodInfoPtr_get_OriginalType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666303);
			ParameterDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_Type_Boolean_Object_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666304);
			ParameterDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_Type_Boolean_Object_Boolean_Boolean_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666305);
			ParameterDescriptor.NativeMethodInfoPtr__ctor_Public_Void_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666306);
			ParameterDescriptor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666307);
			ParameterDescriptor.NativeMethodInfoPtr_RestrictType_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666308);
			ParameterDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr, 100666309);
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x00059B7C File Offset: 0x00057D7C
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x00059BB4 File Offset: 0x00057DB4
		public unsafe string Name
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x00059BF8 File Offset: 0x00057DF8
		// (set) Token: 0x060010BE RID: 4286 RVA: 0x00059C38 File Offset: 0x00057E38
		public unsafe Type Type
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr_get_Type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr_set_Type_Private_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x00059C7C File Offset: 0x00057E7C
		// (set) Token: 0x060010C0 RID: 4288 RVA: 0x00059CB8 File Offset: 0x00057EB8
		public unsafe bool HasDefaultValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr_get_HasDefaultValue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr_set_HasDefaultValue_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x00059CF8 File Offset: 0x00057EF8
		// (set) Token: 0x060010C2 RID: 4290 RVA: 0x00059D38 File Offset: 0x00057F38
		public unsafe Object DefaultValue
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr_get_DefaultValue_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr_set_DefaultValue_Private_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x00059D7C File Offset: 0x00057F7C
		// (set) Token: 0x060010C4 RID: 4292 RVA: 0x00059DB8 File Offset: 0x00057FB8
		public unsafe bool IsOut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr_get_IsOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr_set_IsOut_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x00059DF8 File Offset: 0x00057FF8
		// (set) Token: 0x060010C6 RID: 4294 RVA: 0x00059E34 File Offset: 0x00058034
		public unsafe bool IsRef
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr_get_IsRef_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 42721, RefRangeEnd = 42723, XrefRangeStart = 42721, XrefRangeEnd = 42721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr_set_IsRef_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x00059E74 File Offset: 0x00058074
		// (set) Token: 0x060010C8 RID: 4296 RVA: 0x00059EB0 File Offset: 0x000580B0
		public unsafe bool IsVarArgs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr_get_IsVarArgs_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr_set_IsVarArgs_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x00059EF0 File Offset: 0x000580F0
		public unsafe bool HasBeenRestricted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42723, XrefRangeEnd = 42726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr_get_HasBeenRestricted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x060010CA RID: 4298 RVA: 0x00059F2C File Offset: 0x0005812C
		public unsafe Type OriginalType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 42726, RefRangeEnd = 42728, XrefRangeStart = 42726, XrefRangeEnd = 42726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr_get_OriginalType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00059F6C File Offset: 0x0005816C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 42732, RefRangeEnd = 42737, XrefRangeStart = 42728, XrefRangeEnd = 42732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParameterDescriptor(string name, Type type, bool hasDefaultValue = false, Object defaultValue = null, bool isOut = false, bool isRef = false, bool isVarArgs = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasDefaultValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOut;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRef;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVarArgs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_Type_Boolean_Object_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0005A014 File Offset: 0x00058214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42737, XrefRangeEnd = 42750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParameterDescriptor(string name, Type type, bool hasDefaultValue, Object defaultValue, bool isOut, bool isRef, bool isVarArgs, Type typeRestriction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasDefaultValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOut;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRef;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVarArgs;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeRestriction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr__ctor_Public_Void_String_Type_Boolean_Object_Boolean_Boolean_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x0005A0D0 File Offset: 0x000582D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 42766, RefRangeEnd = 42769, XrefRangeStart = 42750, XrefRangeEnd = 42766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParameterDescriptor(ParameterInfo pi)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterDescriptor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr__ctor_Public_Void_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0005A11C File Offset: 0x0005831C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42769, XrefRangeEnd = 42776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0005A154 File Offset: 0x00058354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42776, XrefRangeEnd = 42795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestrictType(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr_RestrictType_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0005A198 File Offset: 0x00058398
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 42844, RefRangeEnd = 42847, XrefRangeStart = 42795, XrefRangeEnd = 42844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareForWiring(Table table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x00006F3A File Offset: 0x0000513A
		public ParameterDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x060010D2 RID: 4306 RVA: 0x0005A1DC File Offset: 0x000583DC
		// (set) Token: 0x060010D3 RID: 4307 RVA: 0x00006F43 File Offset: 0x00005143
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterDescriptor.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterDescriptor.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x060010D4 RID: 4308 RVA: 0x0005A204 File Offset: 0x00058404
		// (set) Token: 0x060010D5 RID: 4309 RVA: 0x00006F62 File Offset: 0x00005162
		public unsafe Type _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterDescriptor.NativeFieldInfoPtr__Type_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterDescriptor.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x060010D6 RID: 4310 RVA: 0x0005A234 File Offset: 0x00058434
		// (set) Token: 0x060010D7 RID: 4311 RVA: 0x00006F81 File Offset: 0x00005181
		public unsafe bool _HasDefaultValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterDescriptor.NativeFieldInfoPtr__HasDefaultValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterDescriptor.NativeFieldInfoPtr__HasDefaultValue_k__BackingField)) = value;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x060010D8 RID: 4312 RVA: 0x0005A25C File Offset: 0x0005845C
		// (set) Token: 0x060010D9 RID: 4313 RVA: 0x00006F9C File Offset: 0x0000519C
		public unsafe Object _DefaultValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterDescriptor.NativeFieldInfoPtr__DefaultValue_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterDescriptor.NativeFieldInfoPtr__DefaultValue_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x060010DA RID: 4314 RVA: 0x0005A28C File Offset: 0x0005848C
		// (set) Token: 0x060010DB RID: 4315 RVA: 0x00006FBB File Offset: 0x000051BB
		public unsafe bool _IsOut_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterDescriptor.NativeFieldInfoPtr__IsOut_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterDescriptor.NativeFieldInfoPtr__IsOut_k__BackingField)) = value;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x0005A2B4 File Offset: 0x000584B4
		// (set) Token: 0x060010DD RID: 4317 RVA: 0x00006FD6 File Offset: 0x000051D6
		public unsafe bool _IsRef_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterDescriptor.NativeFieldInfoPtr__IsRef_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterDescriptor.NativeFieldInfoPtr__IsRef_k__BackingField)) = value;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x0005A2DC File Offset: 0x000584DC
		// (set) Token: 0x060010DF RID: 4319 RVA: 0x00006FF1 File Offset: 0x000051F1
		public unsafe bool _IsVarArgs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterDescriptor.NativeFieldInfoPtr__IsVarArgs_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterDescriptor.NativeFieldInfoPtr__IsVarArgs_k__BackingField)) = value;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x0005A304 File Offset: 0x00058504
		// (set) Token: 0x060010E1 RID: 4321 RVA: 0x0000700C File Offset: 0x0000520C
		public unsafe Type m_OriginalType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterDescriptor.NativeFieldInfoPtr_m_OriginalType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterDescriptor.NativeFieldInfoPtr_m_OriginalType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeFieldInfoPtr__HasDefaultValue_k__BackingField;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeFieldInfoPtr__DefaultValue_k__BackingField;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeFieldInfoPtr__IsOut_k__BackingField;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeFieldInfoPtr__IsRef_k__BackingField;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeFieldInfoPtr__IsVarArgs_k__BackingField;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeFieldInfoPtr_m_OriginalType;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Private_set_Void_String_0;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_Type_0;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Private_set_Void_Type_0;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDefaultValue_Public_get_Boolean_0;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeMethodInfoPtr_set_HasDefaultValue_Private_set_Void_Boolean_0;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValue_Public_get_Object_0;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValue_Private_set_Void_Object_0;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOut_Public_get_Boolean_0;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOut_Private_set_Void_Boolean_0;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRef_Public_get_Boolean_0;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRef_Private_set_Void_Boolean_0;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVarArgs_Public_get_Boolean_0;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeMethodInfoPtr_set_IsVarArgs_Private_set_Void_Boolean_0;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeMethodInfoPtr_get_HasBeenRestricted_Public_get_Boolean_0;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalType_Public_get_Type_0;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Type_Boolean_Object_Boolean_Boolean_Boolean_0;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Type_Boolean_Object_Boolean_Boolean_Boolean_Type_0;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ParameterInfo_0;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr_RestrictType_Public_Void_Type_0;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0;
	}
}
