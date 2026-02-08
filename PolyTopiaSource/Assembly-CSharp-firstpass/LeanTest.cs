using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000009 RID: 9
public class LeanTest : Object
{
	// Token: 0x06000070 RID: 112 RVA: 0x00011FF8 File Offset: 0x000101F8
	// Note: this type is marked as 'beforefieldinit'.
	static LeanTest()
	{
		Il2CppClassPointerStore<LeanTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LeanTest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanTest>.NativeClassPtr);
		LeanTest.NativeFieldInfoPtr_expected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, "expected");
		LeanTest.NativeFieldInfoPtr_tests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, "tests");
		LeanTest.NativeFieldInfoPtr_passes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, "passes");
		LeanTest.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, "timeout");
		LeanTest.NativeFieldInfoPtr_timeoutStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, "timeoutStarted");
		LeanTest.NativeFieldInfoPtr_testsFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, "testsFinished");
		LeanTest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100663367);
		LeanTest.NativeMethodInfoPtr_debug_Public_Static_Void_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100663359);
		LeanTest.NativeMethodInfoPtr_expect_Public_Static_Void_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100663360);
		LeanTest.NativeMethodInfoPtr_padRight_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100663361);
		LeanTest.NativeMethodInfoPtr_printOutLength_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100663362);
		LeanTest.NativeMethodInfoPtr_formatBC_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100663363);
		LeanTest.NativeMethodInfoPtr_formatB_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100663364);
		LeanTest.NativeMethodInfoPtr_formatC_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100663365);
		LeanTest.NativeMethodInfoPtr_overview_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTest>.NativeClassPtr, 100663366);
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00012154 File Offset: 0x00010354
	[CallerCount(2275)]
	[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LeanTest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanTest>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00012190 File Offset: 0x00010390
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10242, XrefRangeEnd = 10246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void debug(string name, bool didPass, string failExplaination = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref didPass;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failExplaination);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTest.NativeMethodInfoPtr_debug_Public_Static_Void_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000073 RID: 115 RVA: 0x000121E8 File Offset: 0x000103E8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 10358, RefRangeEnd = 10359, XrefRangeStart = 10246, XrefRangeEnd = 10358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void expect(bool didPass, string definition, string failExplaination = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref didPass;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(definition);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failExplaination);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTest.NativeMethodInfoPtr_expect_Public_Static_Void_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00012240 File Offset: 0x00010440
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10359, XrefRangeEnd = 10364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string padRight(int len)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTest.NativeMethodInfoPtr_padRight_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00012278 File Offset: 0x00010478
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10364, XrefRangeEnd = 10374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float printOutLength(string str)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTest.NativeMethodInfoPtr_printOutLength_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000076 RID: 118 RVA: 0x000122BC File Offset: 0x000104BC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 10383, RefRangeEnd = 10385, XrefRangeStart = 10374, XrefRangeEnd = 10383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string formatBC(string str, string color)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(color);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTest.NativeMethodInfoPtr_formatBC_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000077 RID: 119 RVA: 0x0001230C File Offset: 0x0001050C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10385, XrefRangeEnd = 10390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string formatB(string str)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTest.NativeMethodInfoPtr_formatB_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00012348 File Offset: 0x00010548
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 10407, RefRangeEnd = 10409, XrefRangeStart = 10390, XrefRangeEnd = 10407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string formatC(string str, string color)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(color);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTest.NativeMethodInfoPtr_formatC_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00012398 File Offset: 0x00010598
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 10462, RefRangeEnd = 10463, XrefRangeStart = 10409, XrefRangeEnd = 10462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void overview()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTest.NativeMethodInfoPtr_overview_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00002235 File Offset: 0x00000435
	public LeanTest(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x0600007B RID: 123 RVA: 0x000123C0 File Offset: 0x000105C0
	// (set) Token: 0x0600007C RID: 124 RVA: 0x0000223E File Offset: 0x0000043E
	public unsafe static int expected
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LeanTest.NativeFieldInfoPtr_expected, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTest.NativeFieldInfoPtr_expected, (void*)(&value));
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x0600007D RID: 125 RVA: 0x000123DC File Offset: 0x000105DC
	// (set) Token: 0x0600007E RID: 126 RVA: 0x0000224C File Offset: 0x0000044C
	public unsafe static int tests
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LeanTest.NativeFieldInfoPtr_tests, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTest.NativeFieldInfoPtr_tests, (void*)(&value));
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x0600007F RID: 127 RVA: 0x000123F8 File Offset: 0x000105F8
	// (set) Token: 0x06000080 RID: 128 RVA: 0x0000225A File Offset: 0x0000045A
	public unsafe static int passes
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LeanTest.NativeFieldInfoPtr_passes, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTest.NativeFieldInfoPtr_passes, (void*)(&value));
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000081 RID: 129 RVA: 0x00012414 File Offset: 0x00010614
	// (set) Token: 0x06000082 RID: 130 RVA: 0x00002268 File Offset: 0x00000468
	public unsafe static float timeout
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(LeanTest.NativeFieldInfoPtr_timeout, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTest.NativeFieldInfoPtr_timeout, (void*)(&value));
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000083 RID: 131 RVA: 0x00012430 File Offset: 0x00010630
	// (set) Token: 0x06000084 RID: 132 RVA: 0x00002276 File Offset: 0x00000476
	public unsafe static bool timeoutStarted
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(LeanTest.NativeFieldInfoPtr_timeoutStarted, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTest.NativeFieldInfoPtr_timeoutStarted, (void*)(&value));
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x06000085 RID: 133 RVA: 0x0001244C File Offset: 0x0001064C
	// (set) Token: 0x06000086 RID: 134 RVA: 0x00002284 File Offset: 0x00000484
	public unsafe static bool testsFinished
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(LeanTest.NativeFieldInfoPtr_testsFinished, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LeanTest.NativeFieldInfoPtr_testsFinished, (void*)(&value));
		}
	}

	// Token: 0x0400004D RID: 77
	private static readonly IntPtr NativeFieldInfoPtr_expected;

	// Token: 0x0400004E RID: 78
	private static readonly IntPtr NativeFieldInfoPtr_tests;

	// Token: 0x0400004F RID: 79
	private static readonly IntPtr NativeFieldInfoPtr_passes;

	// Token: 0x04000050 RID: 80
	private static readonly IntPtr NativeFieldInfoPtr_timeout;

	// Token: 0x04000051 RID: 81
	private static readonly IntPtr NativeFieldInfoPtr_timeoutStarted;

	// Token: 0x04000052 RID: 82
	private static readonly IntPtr NativeFieldInfoPtr_testsFinished;

	// Token: 0x04000053 RID: 83
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000054 RID: 84
	private static readonly IntPtr NativeMethodInfoPtr_debug_Public_Static_Void_String_Boolean_String_0;

	// Token: 0x04000055 RID: 85
	private static readonly IntPtr NativeMethodInfoPtr_expect_Public_Static_Void_Boolean_String_String_0;

	// Token: 0x04000056 RID: 86
	private static readonly IntPtr NativeMethodInfoPtr_padRight_Public_Static_String_Int32_0;

	// Token: 0x04000057 RID: 87
	private static readonly IntPtr NativeMethodInfoPtr_printOutLength_Public_Static_Single_String_0;

	// Token: 0x04000058 RID: 88
	private static readonly IntPtr NativeMethodInfoPtr_formatBC_Public_Static_String_String_String_0;

	// Token: 0x04000059 RID: 89
	private static readonly IntPtr NativeMethodInfoPtr_formatB_Public_Static_String_String_0;

	// Token: 0x0400005A RID: 90
	private static readonly IntPtr NativeMethodInfoPtr_formatC_Public_Static_String_String_String_0;

	// Token: 0x0400005B RID: 91
	private static readonly IntPtr NativeMethodInfoPtr_overview_Public_Static_Void_0;
}
