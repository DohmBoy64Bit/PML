using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace MoonSharp.Interpreter.IO
{
	// Token: 0x02000096 RID: 150
	public class BinDumpBinaryReader : BinaryReader
	{
		// Token: 0x06000C52 RID: 3154 RVA: 0x00045C10 File Offset: 0x00043E10
		// Note: this type is marked as 'beforefieldinit'.
		static BinDumpBinaryReader()
		{
			Il2CppClassPointerStore<BinDumpBinaryReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.IO", "BinDumpBinaryReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinDumpBinaryReader>.NativeClassPtr);
			BinDumpBinaryReader.NativeFieldInfoPtr_m_Strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinDumpBinaryReader>.NativeClassPtr, "m_Strings");
			BinDumpBinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinDumpBinaryReader>.NativeClassPtr, 100665422);
			BinDumpBinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinDumpBinaryReader>.NativeClassPtr, 100665423);
			BinDumpBinaryReader.NativeMethodInfoPtr_ReadInt32_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinDumpBinaryReader>.NativeClassPtr, 100665424);
			BinDumpBinaryReader.NativeMethodInfoPtr_ReadUInt32_Public_Virtual_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinDumpBinaryReader>.NativeClassPtr, 100665425);
			BinDumpBinaryReader.NativeMethodInfoPtr_ReadString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinDumpBinaryReader>.NativeClassPtr, 100665426);
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00045CB8 File Offset: 0x00043EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32838, XrefRangeEnd = 32846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinDumpBinaryReader(Stream s)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinDumpBinaryReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinDumpBinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00045D04 File Offset: 0x00043F04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32854, RefRangeEnd = 32855, XrefRangeStart = 32846, XrefRangeEnd = 32854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinDumpBinaryReader(Stream s, Encoding e)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinDumpBinaryReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinDumpBinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00045D64 File Offset: 0x00043F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32855, XrefRangeEnd = 32856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ReadInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinDumpBinaryReader.NativeMethodInfoPtr_ReadInt32_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00045DAC File Offset: 0x00043FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32856, XrefRangeEnd = 32857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override uint ReadUInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinDumpBinaryReader.NativeMethodInfoPtr_ReadUInt32_Public_Virtual_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x00045DF4 File Offset: 0x00043FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32857, XrefRangeEnd = 32863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinDumpBinaryReader.NativeMethodInfoPtr_ReadString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00005AC5 File Offset: 0x00003CC5
		public BinDumpBinaryReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00045E38 File Offset: 0x00044038
		// (set) Token: 0x06000C5A RID: 3162 RVA: 0x00005ACE File Offset: 0x00003CCE
		public unsafe List<string> m_Strings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinDumpBinaryReader.NativeFieldInfoPtr_m_Strings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinDumpBinaryReader.NativeFieldInfoPtr_m_Strings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeFieldInfoPtr_m_Strings;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_0;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt32_Public_Virtual_Int32_0;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr_ReadUInt32_Public_Virtual_UInt32_0;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr_ReadString_Public_Virtual_String_0;
	}
}
