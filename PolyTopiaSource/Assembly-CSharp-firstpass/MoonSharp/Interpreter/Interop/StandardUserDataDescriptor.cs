using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000BB RID: 187
	public class StandardUserDataDescriptor : DispatchingUserDataDescriptor
	{
		// Token: 0x06000EC9 RID: 3785 RVA: 0x00051118 File Offset: 0x0004F318
		// Note: this type is marked as 'beforefieldinit'.
		static StandardUserDataDescriptor()
		{
			Il2CppClassPointerStore<StandardUserDataDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "StandardUserDataDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardUserDataDescriptor>.NativeClassPtr);
			StandardUserDataDescriptor.NativeFieldInfoPtr__AccessMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardUserDataDescriptor>.NativeClassPtr, "<AccessMode>k__BackingField");
			StandardUserDataDescriptor.NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardUserDataDescriptor>.NativeClassPtr, 100665953);
			StandardUserDataDescriptor.NativeMethodInfoPtr_set_AccessMode_Private_set_Void_InteropAccessMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardUserDataDescriptor>.NativeClassPtr, 100665954);
			StandardUserDataDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_InteropAccessMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardUserDataDescriptor>.NativeClassPtr, 100665955);
			StandardUserDataDescriptor.NativeMethodInfoPtr_FillMemberList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardUserDataDescriptor>.NativeClassPtr, 100665956);
			StandardUserDataDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardUserDataDescriptor>.NativeClassPtr, 100665957);
			StandardUserDataDescriptor.NativeMethodInfoPtr_Serialize_Private_Void_Table_IEnumerable_1_KeyValuePair_2_String_IMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardUserDataDescriptor>.NativeClassPtr, 100665958);
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x000511D4 File Offset: 0x0004F3D4
		// (set) Token: 0x06000ECB RID: 3787 RVA: 0x00051214 File Offset: 0x0004F414
		public unsafe InteropAccessMode AccessMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardUserDataDescriptor.NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InteropAccessMode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardUserDataDescriptor.NativeMethodInfoPtr_set_AccessMode_Private_set_Void_InteropAccessMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x00051258 File Offset: 0x0004F458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38168, XrefRangeEnd = 38191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandardUserDataDescriptor(Type type, InteropAccessMode accessMode, string friendlyName = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandardUserDataDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMode);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardUserDataDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_InteropAccessMode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x000512C8 File Offset: 0x0004F4C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 38503, RefRangeEnd = 38505, XrefRangeStart = 38191, XrefRangeEnd = 38503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillMemberList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardUserDataDescriptor.NativeMethodInfoPtr_FillMemberList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x000512FC File Offset: 0x0004F4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38505, XrefRangeEnd = 38544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PrepareForWiring(Table t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardUserDataDescriptor.NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00051340 File Offset: 0x0004F540
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 38583, RefRangeEnd = 38585, XrefRangeStart = 38544, XrefRangeEnd = 38583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(Table t, IEnumerable<KeyValuePair<string, IMemberDescriptor>> members)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(members);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardUserDataDescriptor.NativeMethodInfoPtr_Serialize_Private_Void_Table_IEnumerable_1_KeyValuePair_2_String_IMemberDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x000067BB File Offset: 0x000049BB
		public StandardUserDataDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x00051394 File Offset: 0x0004F594
		// (set) Token: 0x06000ED2 RID: 3794 RVA: 0x000067C4 File Offset: 0x000049C4
		public unsafe InteropAccessMode _AccessMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardUserDataDescriptor.NativeFieldInfoPtr__AccessMode_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteropAccessMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardUserDataDescriptor.NativeFieldInfoPtr__AccessMode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeFieldInfoPtr__AccessMode_k__BackingField;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessMode_Public_get_InteropAccessMode_0;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeMethodInfoPtr_set_AccessMode_Private_set_Void_InteropAccessMode_0;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_InteropAccessMode_String_0;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeMethodInfoPtr_FillMemberList_Private_Void_0;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeMethodInfoPtr_PrepareForWiring_Public_Virtual_Final_New_Void_Table_0;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Private_Void_Table_IEnumerable_1_KeyValuePair_2_String_IMemberDescriptor_0;

		// Token: 0x020001D0 RID: 464
		[ObfuscatedName("MoonSharp.Interpreter.Interop.StandardUserDataDescriptor+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001C5A RID: 7258 RVA: 0x00089604 File Offset: 0x00087804
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StandardUserDataDescriptor.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StandardUserDataDescriptor>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardUserDataDescriptor.__c>.NativeClassPtr);
				StandardUserDataDescriptor.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardUserDataDescriptor.__c>.NativeClassPtr, "<>9");
				StandardUserDataDescriptor.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardUserDataDescriptor.__c>.NativeClassPtr, "<>9__5_0");
				StandardUserDataDescriptor.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardUserDataDescriptor.__c>.NativeClassPtr, 100665960);
				StandardUserDataDescriptor.__c.NativeMethodInfoPtr__FillMemberList_b__5_0_Internal_String_MoonSharpHideMemberAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardUserDataDescriptor.__c>.NativeClassPtr, 100665961);
			}

			// Token: 0x06001C5B RID: 7259 RVA: 0x00089680 File Offset: 0x00087880
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandardUserDataDescriptor.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardUserDataDescriptor.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C5C RID: 7260 RVA: 0x000896BC File Offset: 0x000878BC
			[CallerCount(0)]
			public unsafe string _FillMemberList_b__5_0(MoonSharpHideMemberAttribute a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardUserDataDescriptor.__c.NativeMethodInfoPtr__FillMemberList_b__5_0_Internal_String_MoonSharpHideMemberAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001C5D RID: 7261 RVA: 0x0000B2A3 File Offset: 0x000094A3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000675 RID: 1653
			// (get) Token: 0x06001C5E RID: 7262 RVA: 0x00089704 File Offset: 0x00087904
			// (set) Token: 0x06001C5F RID: 7263 RVA: 0x0000B2AC File Offset: 0x000094AC
			public unsafe static StandardUserDataDescriptor.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardUserDataDescriptor.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandardUserDataDescriptor.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardUserDataDescriptor.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000676 RID: 1654
			// (get) Token: 0x06001C60 RID: 7264 RVA: 0x0008972C File Offset: 0x0008792C
			// (set) Token: 0x06001C61 RID: 7265 RVA: 0x0000B2BE File Offset: 0x000094BE
			public unsafe static Func<MoonSharpHideMemberAttribute, string> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StandardUserDataDescriptor.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MoonSharpHideMemberAttribute, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StandardUserDataDescriptor.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016C6 RID: 5830
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040016C7 RID: 5831
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040016C8 RID: 5832
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016C9 RID: 5833
			private static readonly IntPtr NativeMethodInfoPtr__FillMemberList_b__5_0_Internal_String_MoonSharpHideMemberAttribute_0;
		}
	}
}
