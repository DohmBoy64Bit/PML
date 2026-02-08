using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000BA RID: 186
	public class StandardGenericsUserDataDescriptor : Object
	{
		// Token: 0x06000EB4 RID: 3764 RVA: 0x00050AB8 File Offset: 0x0004ECB8
		// Note: this type is marked as 'beforefieldinit'.
		static StandardGenericsUserDataDescriptor()
		{
			Il2CppClassPointerStore<StandardGenericsUserDataDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "StandardGenericsUserDataDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardGenericsUserDataDescriptor>.NativeClassPtr);
			StandardGenericsUserDataDescriptor.NativeFieldInfoPtr__AccessMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardGenericsUserDataDescriptor>.NativeClassPtr, "<AccessMode>k__BackingField");
			StandardGenericsUserDataDescriptor.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardGenericsUserDataDescriptor>.NativeClassPtr, "<Name>k__BackingField");
			StandardGenericsUserDataDescriptor.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardGenericsUserDataDescriptor>.NativeClassPtr, "<Type>k__BackingField");
			StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardGenericsUserDataDescriptor>.NativeClassPtr, 100665940);
			StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_set_AccessMode_Private_set_Void_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardGenericsUserDataDescriptor>.NativeClassPtr, 100665941);
			StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardGenericsUserDataDescriptor>.NativeClassPtr, 100665943);
			StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardGenericsUserDataDescriptor>.NativeClassPtr, 100665944);
			StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardGenericsUserDataDescriptor>.NativeClassPtr, 100665945);
			StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_set_Type_Private_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardGenericsUserDataDescriptor>.NativeClassPtr, 100665946);
			StandardGenericsUserDataDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardGenericsUserDataDescriptor>.NativeClassPtr, 100665942);
			StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_Index_Public_Virtual_Final_New_DynValue_Script_Object_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardGenericsUserDataDescriptor>.NativeClassPtr, 100665947);
			StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_SetIndex_Public_Virtual_Final_New_Boolean_Script_Object_DynValue_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardGenericsUserDataDescriptor>.NativeClassPtr, 100665948);
			StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_AsString_Public_Virtual_Final_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardGenericsUserDataDescriptor>.NativeClassPtr, 100665949);
			StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_MetaIndex_Public_Virtual_Final_New_DynValue_Script_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardGenericsUserDataDescriptor>.NativeClassPtr, 100665950);
			StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_IsTypeCompatible_Public_Virtual_Final_New_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardGenericsUserDataDescriptor>.NativeClassPtr, 100665951);
			StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_Generate_Public_Virtual_Final_New_IUserDataDescriptor_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardGenericsUserDataDescriptor>.NativeClassPtr, 100665952);
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x00050C28 File Offset: 0x0004EE28
		// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x00050C68 File Offset: 0x0004EE68
		public unsafe InteropAccessMode AccessMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_set_AccessMode_Private_set_Void_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x00050CAC File Offset: 0x0004EEAC
		// (set) Token: 0x06000EB8 RID: 3768 RVA: 0x00050CE4 File Offset: 0x0004EEE4
		public unsafe virtual string Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21274, RefRangeEnd = 21282, XrefRangeStart = 21274, XrefRangeEnd = 21282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x00050D28 File Offset: 0x0004EF28
		// (set) Token: 0x06000EBA RID: 3770 RVA: 0x00050D68 File Offset: 0x0004EF68
		public unsafe virtual Type Type
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21290, RefRangeEnd = 21298, XrefRangeStart = 21290, XrefRangeEnd = 21298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_set_Type_Private_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00050DAC File Offset: 0x0004EFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38133, XrefRangeEnd = 38146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandardGenericsUserDataDescriptor(Type type, InteropAccessMode accessMode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandardGenericsUserDataDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardGenericsUserDataDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00050E0C File Offset: 0x0004F00C
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynValue Index(Script script, Object obj, DynValue index, bool isDirectIndexing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDirectIndexing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_Index_Public_Virtual_Final_New_DynValue_Script_Object_DynValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x00050E90 File Offset: 0x0004F090
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool SetIndex(Script script, Object obj, DynValue index, DynValue value, bool isDirectIndexing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDirectIndexing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_SetIndex_Public_Virtual_Final_New_Boolean_Script_Object_DynValue_DynValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00050F24 File Offset: 0x0004F124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string AsString(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_AsString_Public_Virtual_Final_New_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00050F6C File Offset: 0x0004F16C
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynValue MetaIndex(Script script, Object obj, string metaname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(metaname);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_MetaIndex_Public_Virtual_Final_New_DynValue_Script_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00050FE0 File Offset: 0x0004F1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38146, XrefRangeEnd = 38154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsTypeCompatible(Type type, Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_IsTypeCompatible_Public_Virtual_Final_New_Boolean_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00051040 File Offset: 0x0004F240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38154, XrefRangeEnd = 38168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IUserDataDescriptor Generate(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardGenericsUserDataDescriptor.NativeMethodInfoPtr_Generate_Public_Virtual_Final_New_IUserDataDescriptor_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00006755 File Offset: 0x00004955
		public StandardGenericsUserDataDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x00051090 File Offset: 0x0004F290
		// (set) Token: 0x06000EC4 RID: 3780 RVA: 0x0000675E File Offset: 0x0000495E
		public unsafe InteropAccessMode _AccessMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardGenericsUserDataDescriptor.NativeFieldInfoPtr__AccessMode_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteropAccessMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardGenericsUserDataDescriptor.NativeFieldInfoPtr__AccessMode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x000510C0 File Offset: 0x0004F2C0
		// (set) Token: 0x06000EC6 RID: 3782 RVA: 0x0000677D File Offset: 0x0000497D
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardGenericsUserDataDescriptor.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardGenericsUserDataDescriptor.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x000510E8 File Offset: 0x0004F2E8
		// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x0000679C File Offset: 0x0000499C
		public unsafe Type _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardGenericsUserDataDescriptor.NativeFieldInfoPtr__Type_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardGenericsUserDataDescriptor.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeFieldInfoPtr__AccessMode_k__BackingField;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeMethodInfoPtr_set_AccessMode_Private_set_Void_InteropAccessMode_0;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Private_set_Void_String_0;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Private_set_Void_Type_0;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_InteropAccessMode_0;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr_Index_Public_Virtual_Final_New_DynValue_Script_Object_DynValue_Boolean_0;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr_SetIndex_Public_Virtual_Final_New_Boolean_Script_Object_DynValue_DynValue_Boolean_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr_AsString_Public_Virtual_Final_New_String_Object_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_MetaIndex_Public_Virtual_Final_New_DynValue_Script_Object_String_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_IsTypeCompatible_Public_Virtual_Final_New_Boolean_Type_Object_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Virtual_Final_New_IUserDataDescriptor_Type_0;
	}
}
