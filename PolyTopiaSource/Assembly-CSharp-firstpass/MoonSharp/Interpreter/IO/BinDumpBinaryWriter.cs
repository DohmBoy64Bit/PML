using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace MoonSharp.Interpreter.IO
{
	// Token: 0x02000097 RID: 151
	public class BinDumpBinaryWriter : BinaryWriter
	{
		// Token: 0x06000C5B RID: 3163 RVA: 0x00045E68 File Offset: 0x00044068
		// Note: this type is marked as 'beforefieldinit'.
		static BinDumpBinaryWriter()
		{
			Il2CppClassPointerStore<BinDumpBinaryWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.IO", "BinDumpBinaryWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinDumpBinaryWriter>.NativeClassPtr);
			BinDumpBinaryWriter.NativeFieldInfoPtr_m_StringMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinDumpBinaryWriter>.NativeClassPtr, "m_StringMap");
			BinDumpBinaryWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinDumpBinaryWriter>.NativeClassPtr, 100665427);
			BinDumpBinaryWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinDumpBinaryWriter>.NativeClassPtr, 100665428);
			BinDumpBinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinDumpBinaryWriter>.NativeClassPtr, 100665429);
			BinDumpBinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinDumpBinaryWriter>.NativeClassPtr, 100665430);
			BinDumpBinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinDumpBinaryWriter>.NativeClassPtr, 100665431);
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00045F10 File Offset: 0x00044110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32863, XrefRangeEnd = 32874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinDumpBinaryWriter(Stream s)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinDumpBinaryWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinDumpBinaryWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00045F5C File Offset: 0x0004415C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32885, RefRangeEnd = 32886, XrefRangeStart = 32874, XrefRangeEnd = 32885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinDumpBinaryWriter(Stream s, Encoding e)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinDumpBinaryWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinDumpBinaryWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00045FBC File Offset: 0x000441BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32886, XrefRangeEnd = 32891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(uint value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinDumpBinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00046008 File Offset: 0x00044208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32891, XrefRangeEnd = 32896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinDumpBinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00046054 File Offset: 0x00044254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32896, XrefRangeEnd = 32907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinDumpBinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00005AED File Offset: 0x00003CED
		public BinDumpBinaryWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x000460A4 File Offset: 0x000442A4
		// (set) Token: 0x06000C63 RID: 3171 RVA: 0x00005AF6 File Offset: 0x00003CF6
		public unsafe Dictionary<string, int> m_StringMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinDumpBinaryWriter.NativeFieldInfoPtr_m_StringMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinDumpBinaryWriter.NativeFieldInfoPtr_m_StringMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeFieldInfoPtr_m_StringMap;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_0;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_UInt32_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Int32_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0;
	}
}
