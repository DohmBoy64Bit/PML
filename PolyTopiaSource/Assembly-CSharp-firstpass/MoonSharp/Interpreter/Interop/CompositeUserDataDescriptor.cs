using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000AC RID: 172
	public class CompositeUserDataDescriptor : Object
	{
		// Token: 0x06000D29 RID: 3369 RVA: 0x00049B18 File Offset: 0x00047D18
		// Note: this type is marked as 'beforefieldinit'.
		static CompositeUserDataDescriptor()
		{
			Il2CppClassPointerStore<CompositeUserDataDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "CompositeUserDataDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompositeUserDataDescriptor>.NativeClassPtr);
			CompositeUserDataDescriptor.NativeFieldInfoPtr_m_Descriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeUserDataDescriptor>.NativeClassPtr, "m_Descriptors");
			CompositeUserDataDescriptor.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeUserDataDescriptor>.NativeClassPtr, "m_Type");
			CompositeUserDataDescriptor.NativeMethodInfoPtr_get_Descriptors_Public_get_IList_1_IUserDataDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeUserDataDescriptor>.NativeClassPtr, 100665572);
			CompositeUserDataDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeUserDataDescriptor>.NativeClassPtr, 100665573);
			CompositeUserDataDescriptor.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeUserDataDescriptor>.NativeClassPtr, 100665574);
			CompositeUserDataDescriptor.NativeMethodInfoPtr__ctor_Public_Void_List_1_IUserDataDescriptor_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeUserDataDescriptor>.NativeClassPtr, 100665571);
			CompositeUserDataDescriptor.NativeMethodInfoPtr_Index_Public_Virtual_Final_New_DynValue_Script_Object_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeUserDataDescriptor>.NativeClassPtr, 100665575);
			CompositeUserDataDescriptor.NativeMethodInfoPtr_SetIndex_Public_Virtual_Final_New_Boolean_Script_Object_DynValue_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeUserDataDescriptor>.NativeClassPtr, 100665576);
			CompositeUserDataDescriptor.NativeMethodInfoPtr_AsString_Public_Virtual_Final_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeUserDataDescriptor>.NativeClassPtr, 100665577);
			CompositeUserDataDescriptor.NativeMethodInfoPtr_MetaIndex_Public_Virtual_Final_New_DynValue_Script_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeUserDataDescriptor>.NativeClassPtr, 100665578);
			CompositeUserDataDescriptor.NativeMethodInfoPtr_IsTypeCompatible_Public_Virtual_Final_New_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeUserDataDescriptor>.NativeClassPtr, 100665579);
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x00049C24 File Offset: 0x00047E24
		public unsafe IList<IUserDataDescriptor> Descriptors
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeUserDataDescriptor.NativeMethodInfoPtr_get_Descriptors_Public_get_IList_1_IUserDataDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IUserDataDescriptor>>(intPtr3) : null;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x00049C64 File Offset: 0x00047E64
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33812, XrefRangeEnd = 33816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeUserDataDescriptor.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x00049C9C File Offset: 0x00047E9C
		public unsafe virtual Type Type
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeUserDataDescriptor.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00049CDC File Offset: 0x00047EDC
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 33819, RefRangeEnd = 33846, XrefRangeStart = 33816, XrefRangeEnd = 33819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompositeUserDataDescriptor(List<IUserDataDescriptor> descriptors, Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompositeUserDataDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(descriptors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeUserDataDescriptor.NativeMethodInfoPtr__ctor_Public_Void_List_1_IUserDataDescriptor_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00049D3C File Offset: 0x00047F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33846, XrefRangeEnd = 33859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynValue Index(Script script, Object obj, DynValue index, bool isNameIndex)
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNameIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeUserDataDescriptor.NativeMethodInfoPtr_Index_Public_Virtual_Final_New_DynValue_Script_Object_DynValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x00049DC0 File Offset: 0x00047FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33859, XrefRangeEnd = 33872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool SetIndex(Script script, Object obj, DynValue index, DynValue value, bool isNameIndex)
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
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNameIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeUserDataDescriptor.NativeMethodInfoPtr_SetIndex_Public_Virtual_Final_New_Boolean_Script_Object_DynValue_DynValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00049E54 File Offset: 0x00048054
		[CallerCount(0)]
		public unsafe virtual string AsString(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeUserDataDescriptor.NativeMethodInfoPtr_AsString_Public_Virtual_Final_New_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00049E9C File Offset: 0x0004809C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33872, XrefRangeEnd = 33885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeUserDataDescriptor.NativeMethodInfoPtr_MetaIndex_Public_Virtual_Final_New_DynValue_Script_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00049F10 File Offset: 0x00048110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33885, XrefRangeEnd = 33893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeUserDataDescriptor.NativeMethodInfoPtr_IsTypeCompatible_Public_Virtual_Final_New_Boolean_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00005E6E File Offset: 0x0000406E
		public CompositeUserDataDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x00049F70 File Offset: 0x00048170
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x00005E77 File Offset: 0x00004077
		public unsafe List<IUserDataDescriptor> m_Descriptors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeUserDataDescriptor.NativeFieldInfoPtr_m_Descriptors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IUserDataDescriptor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeUserDataDescriptor.NativeFieldInfoPtr_m_Descriptors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x00049FA0 File Offset: 0x000481A0
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x00005E96 File Offset: 0x00004096
		public unsafe Type m_Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeUserDataDescriptor.NativeFieldInfoPtr_m_Type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeUserDataDescriptor.NativeFieldInfoPtr_m_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeFieldInfoPtr_m_Descriptors;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr_get_Descriptors_Public_get_IList_1_IUserDataDescriptor_0;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_IUserDataDescriptor_Type_0;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeMethodInfoPtr_Index_Public_Virtual_Final_New_DynValue_Script_Object_DynValue_Boolean_0;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeMethodInfoPtr_SetIndex_Public_Virtual_Final_New_Boolean_Script_Object_DynValue_DynValue_Boolean_0;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr_AsString_Public_Virtual_Final_New_String_Object_0;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeMethodInfoPtr_MetaIndex_Public_Virtual_Final_New_DynValue_Script_Object_String_0;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeMethodInfoPtr_IsTypeCompatible_Public_Virtual_Final_New_Boolean_Type_Object_0;
	}
}
