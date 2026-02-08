using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x0200009E RID: 158
	public class IUserDataDescriptor : Object
	{
		// Token: 0x06000CB5 RID: 3253 RVA: 0x00047908 File Offset: 0x00045B08
		// Note: this type is marked as 'beforefieldinit'.
		static IUserDataDescriptor()
		{
			Il2CppClassPointerStore<IUserDataDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "IUserDataDescriptor");
			IUserDataDescriptor.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataDescriptor>.NativeClassPtr, 100665508);
			IUserDataDescriptor.NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataDescriptor>.NativeClassPtr, 100665509);
			IUserDataDescriptor.NativeMethodInfoPtr_Index_Public_Abstract_Virtual_New_DynValue_Script_Object_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataDescriptor>.NativeClassPtr, 100665510);
			IUserDataDescriptor.NativeMethodInfoPtr_SetIndex_Public_Abstract_Virtual_New_Boolean_Script_Object_DynValue_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataDescriptor>.NativeClassPtr, 100665511);
			IUserDataDescriptor.NativeMethodInfoPtr_AsString_Public_Abstract_Virtual_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataDescriptor>.NativeClassPtr, 100665512);
			IUserDataDescriptor.NativeMethodInfoPtr_MetaIndex_Public_Abstract_Virtual_New_DynValue_Script_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataDescriptor>.NativeClassPtr, 100665513);
			IUserDataDescriptor.NativeMethodInfoPtr_IsTypeCompatible_Public_Abstract_Virtual_New_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataDescriptor>.NativeClassPtr, 100665514);
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x000479BC File Offset: 0x00045BBC
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataDescriptor.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00047A00 File Offset: 0x00045C00
		public unsafe virtual Type Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataDescriptor.NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00047A4C File Offset: 0x00045C4C
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataDescriptor.NativeMethodInfoPtr_Index_Public_Abstract_Virtual_New_DynValue_Script_Object_DynValue_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x00047ADC File Offset: 0x00045CDC
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataDescriptor.NativeMethodInfoPtr_SetIndex_Public_Abstract_Virtual_New_Boolean_Script_Object_DynValue_DynValue_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00047B7C File Offset: 0x00045D7C
		[CallerCount(0)]
		public unsafe virtual string AsString(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataDescriptor.NativeMethodInfoPtr_AsString_Public_Abstract_Virtual_New_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00047BD0 File Offset: 0x00045DD0
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataDescriptor.NativeMethodInfoPtr_MetaIndex_Public_Abstract_Virtual_New_DynValue_Script_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00047C50 File Offset: 0x00045E50
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataDescriptor.NativeMethodInfoPtr_IsTypeCompatible_Public_Abstract_Virtual_New_Boolean_Type_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00005C11 File Offset: 0x00003E11
		public IUserDataDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeMethodInfoPtr_Index_Public_Abstract_Virtual_New_DynValue_Script_Object_DynValue_Boolean_0;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeMethodInfoPtr_SetIndex_Public_Abstract_Virtual_New_Boolean_Script_Object_DynValue_DynValue_Boolean_0;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeMethodInfoPtr_AsString_Public_Abstract_Virtual_New_String_Object_0;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeMethodInfoPtr_MetaIndex_Public_Abstract_Virtual_New_DynValue_Script_Object_String_0;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeMethodInfoPtr_IsTypeCompatible_Public_Abstract_Virtual_New_Boolean_Type_Object_0;
	}
}
