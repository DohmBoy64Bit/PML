using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000034 RID: 52
	public class SymbolRef : Object
	{
		// Token: 0x060006DB RID: 1755 RVA: 0x0002F9E4 File Offset: 0x0002DBE4
		// Note: this type is marked as 'beforefieldinit'.
		static SymbolRef()
		{
			Il2CppClassPointerStore<SymbolRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "SymbolRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr);
			SymbolRef.NativeFieldInfoPtr_s_DefaultEnv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr, "s_DefaultEnv");
			SymbolRef.NativeFieldInfoPtr_i_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr, "i_Type");
			SymbolRef.NativeFieldInfoPtr_i_Env = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr, "i_Env");
			SymbolRef.NativeFieldInfoPtr_i_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr, "i_Index");
			SymbolRef.NativeFieldInfoPtr_i_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr, "i_Name");
			SymbolRef.NativeMethodInfoPtr_get_Type_Public_get_SymbolRefType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr, 100664630);
			SymbolRef.NativeMethodInfoPtr_get_Index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr, 100664631);
			SymbolRef.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr, 100664632);
			SymbolRef.NativeMethodInfoPtr_get_Environment_Public_get_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr, 100664633);
			SymbolRef.NativeMethodInfoPtr_get_DefaultEnv_Public_Static_get_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr, 100664634);
			SymbolRef.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr, 100664643);
			SymbolRef.NativeMethodInfoPtr_Global_Public_Static_SymbolRef_String_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr, 100664635);
			SymbolRef.NativeMethodInfoPtr_Local_Internal_Static_SymbolRef_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr, 100664636);
			SymbolRef.NativeMethodInfoPtr_Upvalue_Internal_Static_SymbolRef_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr, 100664637);
			SymbolRef.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr, 100664638);
			SymbolRef.NativeMethodInfoPtr_WriteBinary_Internal_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr, 100664639);
			SymbolRef.NativeMethodInfoPtr_ReadBinary_Internal_Static_SymbolRef_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr, 100664640);
			SymbolRef.NativeMethodInfoPtr_WriteBinaryEnv_Internal_Void_BinaryWriter_Dictionary_2_SymbolRef_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr, 100664641);
			SymbolRef.NativeMethodInfoPtr_ReadBinaryEnv_Internal_Void_BinaryReader_Il2CppReferenceArray_1_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr, 100664642);
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x0002FB90 File Offset: 0x0002DD90
		public unsafe SymbolRefType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolRef.NativeMethodInfoPtr_get_Type_Public_get_SymbolRefType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRefType>(intPtr3) : null;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x0002FBD0 File Offset: 0x0002DDD0
		public unsafe int Index
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23450, RefRangeEnd = 23451, XrefRangeStart = 23450, XrefRangeEnd = 23450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolRef.NativeMethodInfoPtr_get_Index_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0002FC0C File Offset: 0x0002DE0C
		public unsafe string Name
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolRef.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x0002FC44 File Offset: 0x0002DE44
		public unsafe SymbolRef Environment
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolRef.NativeMethodInfoPtr_get_Environment_Public_get_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x0002FC84 File Offset: 0x0002DE84
		public unsafe static SymbolRef DefaultEnv
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23451, XrefRangeEnd = 23455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolRef.NativeMethodInfoPtr_get_DefaultEnv_Public_Static_get_SymbolRef_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0002FCB8 File Offset: 0x0002DEB8
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymbolRef()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SymbolRef>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolRef.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0002FCF4 File Offset: 0x0002DEF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 23461, RefRangeEnd = 23463, XrefRangeStart = 23455, XrefRangeEnd = 23461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SymbolRef Global(string name, SymbolRef envSymbol)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(envSymbol);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolRef.NativeMethodInfoPtr_Global_Public_Static_SymbolRef_String_SymbolRef_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0002FD4C File Offset: 0x0002DF4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23468, RefRangeEnd = 23469, XrefRangeStart = 23463, XrefRangeEnd = 23468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SymbolRef Local(string name, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolRef.NativeMethodInfoPtr_Local_Internal_Static_SymbolRef_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x0002FDA0 File Offset: 0x0002DFA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 23474, RefRangeEnd = 23477, XrefRangeStart = 23469, XrefRangeEnd = 23474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SymbolRef Upvalue(string name, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolRef.NativeMethodInfoPtr_Upvalue_Internal_Static_SymbolRef_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0002FDF4 File Offset: 0x0002DFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23477, XrefRangeEnd = 23487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymbolRef.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0002FE38 File Offset: 0x0002E038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23496, RefRangeEnd = 23497, XrefRangeStart = 23487, XrefRangeEnd = 23496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteBinary(BinaryWriter bw)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bw);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolRef.NativeMethodInfoPtr_WriteBinary_Internal_Void_BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0002FE7C File Offset: 0x0002E07C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23502, RefRangeEnd = 23503, XrefRangeStart = 23497, XrefRangeEnd = 23502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SymbolRef ReadBinary(BinaryReader br)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(br);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolRef.NativeMethodInfoPtr_ReadBinary_Internal_Static_SymbolRef_BinaryReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0002FEC0 File Offset: 0x0002E0C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23507, RefRangeEnd = 23508, XrefRangeStart = 23503, XrefRangeEnd = 23507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteBinaryEnv(BinaryWriter bw, Dictionary<SymbolRef, int> symbolMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bw);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbolMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolRef.NativeMethodInfoPtr_WriteBinaryEnv_Internal_Void_BinaryWriter_Dictionary_2_SymbolRef_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0002FF14 File Offset: 0x0002E114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23509, RefRangeEnd = 23510, XrefRangeStart = 23508, XrefRangeEnd = 23509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadBinaryEnv(BinaryReader br, Il2CppReferenceArray<SymbolRef> symbolRefs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(br);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbolRefs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolRef.NativeMethodInfoPtr_ReadBinaryEnv_Internal_Void_BinaryReader_Il2CppReferenceArray_1_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00003AA6 File Offset: 0x00001CA6
		public SymbolRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x0002FF68 File Offset: 0x0002E168
		// (set) Token: 0x060006EC RID: 1772 RVA: 0x00003AAF File Offset: 0x00001CAF
		public unsafe static SymbolRef s_DefaultEnv
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SymbolRef.NativeFieldInfoPtr_s_DefaultEnv, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SymbolRef.NativeFieldInfoPtr_s_DefaultEnv, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x0002FF90 File Offset: 0x0002E190
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x00003AC1 File Offset: 0x00001CC1
		public unsafe SymbolRefType i_Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolRef.NativeFieldInfoPtr_i_Type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolRefType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolRef.NativeFieldInfoPtr_i_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x0002FFC0 File Offset: 0x0002E1C0
		// (set) Token: 0x060006F0 RID: 1776 RVA: 0x00003AE0 File Offset: 0x00001CE0
		public unsafe SymbolRef i_Env
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolRef.NativeFieldInfoPtr_i_Env);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolRef.NativeFieldInfoPtr_i_Env), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x0002FFF0 File Offset: 0x0002E1F0
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00003AFF File Offset: 0x00001CFF
		public unsafe int i_Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolRef.NativeFieldInfoPtr_i_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolRef.NativeFieldInfoPtr_i_Index)) = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00030018 File Offset: 0x0002E218
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00003B1A File Offset: 0x00001D1A
		public unsafe string i_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolRef.NativeFieldInfoPtr_i_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolRef.NativeFieldInfoPtr_i_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultEnv;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeFieldInfoPtr_i_Type;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeFieldInfoPtr_i_Env;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeFieldInfoPtr_i_Index;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeFieldInfoPtr_i_Name;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_SymbolRefType_0;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Int32_0;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_get_Environment_Public_get_SymbolRef_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultEnv_Public_Static_get_SymbolRef_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_Global_Public_Static_SymbolRef_String_SymbolRef_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr_Local_Internal_Static_SymbolRef_String_Int32_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr_Upvalue_Internal_Static_SymbolRef_String_Int32_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr_WriteBinary_Internal_Void_BinaryWriter_0;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeMethodInfoPtr_ReadBinary_Internal_Static_SymbolRef_BinaryReader_0;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr_WriteBinaryEnv_Internal_Void_BinaryWriter_Dictionary_2_SymbolRef_Int32_0;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr_ReadBinaryEnv_Internal_Void_BinaryReader_Il2CppReferenceArray_1_SymbolRef_0;
	}
}
