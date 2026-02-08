using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000031 RID: 49
	public class RefIdObject : Object
	{
		// Token: 0x060006C0 RID: 1728 RVA: 0x0002F42C File Offset: 0x0002D62C
		// Note: this type is marked as 'beforefieldinit'.
		static RefIdObject()
		{
			Il2CppClassPointerStore<RefIdObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "RefIdObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefIdObject>.NativeClassPtr);
			RefIdObject.NativeFieldInfoPtr_s_RefIDCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefIdObject>.NativeClassPtr, "s_RefIDCounter");
			RefIdObject.NativeFieldInfoPtr_m_RefID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefIdObject>.NativeClassPtr, "m_RefID");
			RefIdObject.NativeMethodInfoPtr_get_ReferenceID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefIdObject>.NativeClassPtr, 100664619);
			RefIdObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefIdObject>.NativeClassPtr, 100664621);
			RefIdObject.NativeMethodInfoPtr_FormatTypeString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefIdObject>.NativeClassPtr, 100664620);
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x0002F4C0 File Offset: 0x0002D6C0
		public unsafe int ReferenceID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefIdObject.NativeMethodInfoPtr_get_ReferenceID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0002F4FC File Offset: 0x0002D6FC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 23215, RefRangeEnd = 23222, XrefRangeStart = 23212, XrefRangeEnd = 23215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RefIdObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RefIdObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefIdObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0002F538 File Offset: 0x0002D738
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 23227, RefRangeEnd = 23229, XrefRangeStart = 23222, XrefRangeEnd = 23227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatTypeString(string typeString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefIdObject.NativeMethodInfoPtr_FormatTypeString_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00003A14 File Offset: 0x00001C14
		public RefIdObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x0002F580 File Offset: 0x0002D780
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x00003A1D File Offset: 0x00001C1D
		public unsafe static int s_RefIDCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RefIdObject.NativeFieldInfoPtr_s_RefIDCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RefIdObject.NativeFieldInfoPtr_s_RefIDCounter, (void*)(&value));
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x0002F59C File Offset: 0x0002D79C
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00003A2B File Offset: 0x00001C2B
		public unsafe int m_RefID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RefIdObject.NativeFieldInfoPtr_m_RefID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RefIdObject.NativeFieldInfoPtr_m_RefID)) = value;
			}
		}

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeFieldInfoPtr_s_RefIDCounter;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeFieldInfoPtr_m_RefID;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferenceID_Public_get_Int32_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_FormatTypeString_Public_String_String_0;
	}
}
