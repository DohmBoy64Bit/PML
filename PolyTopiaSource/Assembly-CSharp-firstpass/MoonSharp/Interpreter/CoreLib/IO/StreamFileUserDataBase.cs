using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace MoonSharp.Interpreter.CoreLib.IO
{
	// Token: 0x02000120 RID: 288
	public class StreamFileUserDataBase : FileUserDataBase
	{
		// Token: 0x0600154C RID: 5452 RVA: 0x0006E968 File Offset: 0x0006CB68
		// Note: this type is marked as 'beforefieldinit'.
		static StreamFileUserDataBase()
		{
			Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.CoreLib.IO", "StreamFileUserDataBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr);
			StreamFileUserDataBase.NativeFieldInfoPtr_m_Stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr, "m_Stream");
			StreamFileUserDataBase.NativeFieldInfoPtr_m_Reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr, "m_Reader");
			StreamFileUserDataBase.NativeFieldInfoPtr_m_Writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr, "m_Writer");
			StreamFileUserDataBase.NativeFieldInfoPtr_m_Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr, "m_Closed");
			StreamFileUserDataBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr, 100667112);
			StreamFileUserDataBase.NativeMethodInfoPtr_Initialize_Protected_Void_Stream_StreamReader_StreamWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr, 100667099);
			StreamFileUserDataBase.NativeMethodInfoPtr_CheckFileIsNotClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr, 100667100);
			StreamFileUserDataBase.NativeMethodInfoPtr_Eof_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr, 100667101);
			StreamFileUserDataBase.NativeMethodInfoPtr_ReadLine_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr, 100667102);
			StreamFileUserDataBase.NativeMethodInfoPtr_ReadToEnd_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr, 100667103);
			StreamFileUserDataBase.NativeMethodInfoPtr_ReadBuffer_Protected_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr, 100667104);
			StreamFileUserDataBase.NativeMethodInfoPtr_Peek_Protected_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr, 100667105);
			StreamFileUserDataBase.NativeMethodInfoPtr_Write_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr, 100667106);
			StreamFileUserDataBase.NativeMethodInfoPtr_Close_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr, 100667107);
			StreamFileUserDataBase.NativeMethodInfoPtr_flush_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr, 100667108);
			StreamFileUserDataBase.NativeMethodInfoPtr_seek_Public_Virtual_Int64_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr, 100667109);
			StreamFileUserDataBase.NativeMethodInfoPtr_setvbuf_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr, 100667110);
			StreamFileUserDataBase.NativeMethodInfoPtr_isopen_FamOrAssem_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr, 100667111);
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x0006EB00 File Offset: 0x0006CD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamFileUserDataBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamFileUserDataBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamFileUserDataBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x0006EB3C File Offset: 0x0006CD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51595, XrefRangeEnd = 51598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Stream stream, StreamReader reader, StreamWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(writer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamFileUserDataBase.NativeMethodInfoPtr_Initialize_Protected_Void_Stream_StreamReader_StreamWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x0006EBA4 File Offset: 0x0006CDA4
		[CallerCount(0)]
		public unsafe void CheckFileIsNotClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamFileUserDataBase.NativeMethodInfoPtr_CheckFileIsNotClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x0006EBD8 File Offset: 0x0006CDD8
		[CallerCount(0)]
		public unsafe override bool Eof()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamFileUserDataBase.NativeMethodInfoPtr_Eof_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x0006EC20 File Offset: 0x0006CE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51598, XrefRangeEnd = 51605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamFileUserDataBase.NativeMethodInfoPtr_ReadLine_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x0006EC64 File Offset: 0x0006CE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51605, XrefRangeEnd = 51612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadToEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamFileUserDataBase.NativeMethodInfoPtr_ReadToEnd_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x0006ECA8 File Offset: 0x0006CEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51612, XrefRangeEnd = 51616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadBuffer(int p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamFileUserDataBase.NativeMethodInfoPtr_ReadBuffer_Protected_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x0006ECF8 File Offset: 0x0006CEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51616, XrefRangeEnd = 51623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override char Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamFileUserDataBase.NativeMethodInfoPtr_Peek_Protected_Virtual_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x0006ED40 File Offset: 0x0006CF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51623, XrefRangeEnd = 51630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamFileUserDataBase.NativeMethodInfoPtr_Write_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x0006ED90 File Offset: 0x0006CF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51630, XrefRangeEnd = 51633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamFileUserDataBase.NativeMethodInfoPtr_Close_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x0006EDD4 File Offset: 0x0006CFD4
		[CallerCount(0)]
		public unsafe override bool flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamFileUserDataBase.NativeMethodInfoPtr_flush_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x0006EE1C File Offset: 0x0006D01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51633, XrefRangeEnd = 51658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long seek(string whence, long offset = 0L)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(whence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamFileUserDataBase.NativeMethodInfoPtr_seek_Public_Virtual_Int64_String_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x0006EE84 File Offset: 0x0006D084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51658, XrefRangeEnd = 51665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool setvbuf(string mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(mode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamFileUserDataBase.NativeMethodInfoPtr_setvbuf_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x0006EEDC File Offset: 0x0006D0DC
		[CallerCount(0)]
		public unsafe override bool isopen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamFileUserDataBase.NativeMethodInfoPtr_isopen_FamOrAssem_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x000083AD File Offset: 0x000065AD
		public StreamFileUserDataBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x0600155C RID: 5468 RVA: 0x0006EF24 File Offset: 0x0006D124
		// (set) Token: 0x0600155D RID: 5469 RVA: 0x000083B6 File Offset: 0x000065B6
		public unsafe Stream m_Stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamFileUserDataBase.NativeFieldInfoPtr_m_Stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamFileUserDataBase.NativeFieldInfoPtr_m_Stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x0006EF54 File Offset: 0x0006D154
		// (set) Token: 0x0600155F RID: 5471 RVA: 0x000083D5 File Offset: 0x000065D5
		public unsafe StreamReader m_Reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamFileUserDataBase.NativeFieldInfoPtr_m_Reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamFileUserDataBase.NativeFieldInfoPtr_m_Reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x0006EF84 File Offset: 0x0006D184
		// (set) Token: 0x06001561 RID: 5473 RVA: 0x000083F4 File Offset: 0x000065F4
		public unsafe StreamWriter m_Writer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamFileUserDataBase.NativeFieldInfoPtr_m_Writer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamFileUserDataBase.NativeFieldInfoPtr_m_Writer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x0006EFB4 File Offset: 0x0006D1B4
		// (set) Token: 0x06001563 RID: 5475 RVA: 0x00008413 File Offset: 0x00006613
		public unsafe bool m_Closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamFileUserDataBase.NativeFieldInfoPtr_m_Closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamFileUserDataBase.NativeFieldInfoPtr_m_Closed)) = value;
			}
		}

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeFieldInfoPtr_m_Stream;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeFieldInfoPtr_m_Reader;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeFieldInfoPtr_m_Writer;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeFieldInfoPtr_m_Closed;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Void_Stream_StreamReader_StreamWriter_0;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeMethodInfoPtr_CheckFileIsNotClosed_Private_Void_0;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeMethodInfoPtr_Eof_Protected_Virtual_Boolean_0;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Protected_Virtual_String_0;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Protected_Virtual_String_0;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeMethodInfoPtr_ReadBuffer_Protected_Virtual_String_Int32_0;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Protected_Virtual_Char_0;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeMethodInfoPtr_Write_Protected_Virtual_Void_String_0;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_String_0;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeMethodInfoPtr_flush_Public_Virtual_Boolean_0;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeMethodInfoPtr_seek_Public_Virtual_Int64_String_Int64_0;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeMethodInfoPtr_setvbuf_Public_Virtual_Boolean_String_0;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeMethodInfoPtr_isopen_FamOrAssem_Virtual_Boolean_0;
	}
}
