using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace MoonSharp.Interpreter.Interop.Converters
{
	// Token: 0x020000D1 RID: 209
	public static class ScriptToClrConversions : Object
	{
		// Token: 0x0600101D RID: 4125 RVA: 0x00057034 File Offset: 0x00055234
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptToClrConversions()
		{
			Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.Converters", "ScriptToClrConversions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr);
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_MAX_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_MAX_VALUE");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_CUSTOM_CONVERTER_MATCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_CUSTOM_CONVERTER_MATCH");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_EXACT_MATCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_EXACT_MATCH");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_STRING_TO_STRINGBUILDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_STRING_TO_STRINGBUILDER");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_STRING_TO_CHAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_STRING_TO_CHAR");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NIL_TO_NULLABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_NIL_TO_NULLABLE");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NIL_TO_REFTYPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_NIL_TO_REFTYPE");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_VOID_WITH_DEFAULT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_VOID_WITH_DEFAULT");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_VOID_WITHOUT_DEFAULT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_VOID_WITHOUT_DEFAULT");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NIL_WITH_DEFAULT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_NIL_WITH_DEFAULT");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_BOOL_TO_STRING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_BOOL_TO_STRING");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NUMBER_TO_STRING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_NUMBER_TO_STRING");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NUMBER_TO_ENUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_NUMBER_TO_ENUM");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_USERDATA_TO_STRING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_USERDATA_TO_STRING");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_TABLE_CONVERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_TABLE_CONVERSION");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NUMBER_DOWNCAST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_NUMBER_DOWNCAST");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NO_MATCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_NO_MATCH");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NO_EXTRA_PARAMS_BONUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_NO_EXTRA_PARAMS_BONUS");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_EXTRA_PARAMS_MALUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_EXTRA_PARAMS_MALUS");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_BYREF_BONUSMALUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_BYREF_BONUSMALUS");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_VARARGS_MALUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_VARARGS_MALUS");
			ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_VARARGS_EMPTY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, "WEIGHT_VARARGS_EMPTY");
			ScriptToClrConversions.NativeMethodInfoPtr_DynValueToObject_Internal_Static_Object_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, 100666193);
			ScriptToClrConversions.NativeMethodInfoPtr_HasImplicitConversion_Public_Static_MethodInfo_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, 100666194);
			ScriptToClrConversions.NativeMethodInfoPtr_DynValueToObjectOfType_Internal_Static_Object_DynValue_Type_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, 100666195);
			ScriptToClrConversions.NativeMethodInfoPtr_DynValueToObjectOfTypeWeight_Internal_Static_Int32_DynValue_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, 100666196);
			ScriptToClrConversions.NativeMethodInfoPtr_GetNumericTypeWeight_Private_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptToClrConversions>.NativeClassPtr, 100666197);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00057280 File Offset: 0x00055480
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 41561, RefRangeEnd = 41567, XrefRangeStart = 41548, XrefRangeEnd = 41561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DynValueToObject(DynValue value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptToClrConversions.NativeMethodInfoPtr_DynValueToObject_Internal_Static_Object_DynValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x000572C4 File Offset: 0x000554C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41567, XrefRangeEnd = 41579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo HasImplicitConversion(Type baseType, Type targetType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptToClrConversions.NativeMethodInfoPtr_HasImplicitConversion_Public_Static_MethodInfo_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x0005731C File Offset: 0x0005551C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 41627, RefRangeEnd = 41640, XrefRangeStart = 41579, XrefRangeEnd = 41627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DynValueToObjectOfType(DynValue value, Type desiredType, Object defaultValue, bool isOptional)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desiredType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOptional;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptToClrConversions.NativeMethodInfoPtr_DynValueToObjectOfType_Internal_Static_Object_DynValue_Type_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00057394 File Offset: 0x00055594
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41680, RefRangeEnd = 41681, XrefRangeStart = 41640, XrefRangeEnd = 41680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DynValueToObjectOfTypeWeight(DynValue value, Type desiredType, bool isOptional)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desiredType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOptional;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptToClrConversions.NativeMethodInfoPtr_DynValueToObjectOfTypeWeight_Internal_Static_Int32_DynValue_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x000573F8 File Offset: 0x000555F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41681, XrefRangeEnd = 41692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNumericTypeWeight(Type desiredType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desiredType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptToClrConversions.NativeMethodInfoPtr_GetNumericTypeWeight_Private_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00006C91 File Offset: 0x00004E91
		public ScriptToClrConversions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x0005743C File Offset: 0x0005563C
		// (set) Token: 0x06001025 RID: 4133 RVA: 0x00006C9A File Offset: 0x00004E9A
		public unsafe static int WEIGHT_MAX_VALUE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_MAX_VALUE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_MAX_VALUE, (void*)(&value));
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x00057458 File Offset: 0x00055658
		// (set) Token: 0x06001027 RID: 4135 RVA: 0x00006CA8 File Offset: 0x00004EA8
		public unsafe static int WEIGHT_CUSTOM_CONVERTER_MATCH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_CUSTOM_CONVERTER_MATCH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_CUSTOM_CONVERTER_MATCH, (void*)(&value));
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x00057474 File Offset: 0x00055674
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x00006CB6 File Offset: 0x00004EB6
		public unsafe static int WEIGHT_EXACT_MATCH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_EXACT_MATCH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_EXACT_MATCH, (void*)(&value));
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x00057490 File Offset: 0x00055690
		// (set) Token: 0x0600102B RID: 4139 RVA: 0x00006CC4 File Offset: 0x00004EC4
		public unsafe static int WEIGHT_STRING_TO_STRINGBUILDER
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_STRING_TO_STRINGBUILDER, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_STRING_TO_STRINGBUILDER, (void*)(&value));
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x000574AC File Offset: 0x000556AC
		// (set) Token: 0x0600102D RID: 4141 RVA: 0x00006CD2 File Offset: 0x00004ED2
		public unsafe static int WEIGHT_STRING_TO_CHAR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_STRING_TO_CHAR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_STRING_TO_CHAR, (void*)(&value));
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x000574C8 File Offset: 0x000556C8
		// (set) Token: 0x0600102F RID: 4143 RVA: 0x00006CE0 File Offset: 0x00004EE0
		public unsafe static int WEIGHT_NIL_TO_NULLABLE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NIL_TO_NULLABLE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NIL_TO_NULLABLE, (void*)(&value));
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x000574E4 File Offset: 0x000556E4
		// (set) Token: 0x06001031 RID: 4145 RVA: 0x00006CEE File Offset: 0x00004EEE
		public unsafe static int WEIGHT_NIL_TO_REFTYPE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NIL_TO_REFTYPE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NIL_TO_REFTYPE, (void*)(&value));
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x00057500 File Offset: 0x00055700
		// (set) Token: 0x06001033 RID: 4147 RVA: 0x00006CFC File Offset: 0x00004EFC
		public unsafe static int WEIGHT_VOID_WITH_DEFAULT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_VOID_WITH_DEFAULT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_VOID_WITH_DEFAULT, (void*)(&value));
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x0005751C File Offset: 0x0005571C
		// (set) Token: 0x06001035 RID: 4149 RVA: 0x00006D0A File Offset: 0x00004F0A
		public unsafe static int WEIGHT_VOID_WITHOUT_DEFAULT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_VOID_WITHOUT_DEFAULT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_VOID_WITHOUT_DEFAULT, (void*)(&value));
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x00057538 File Offset: 0x00055738
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x00006D18 File Offset: 0x00004F18
		public unsafe static int WEIGHT_NIL_WITH_DEFAULT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NIL_WITH_DEFAULT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NIL_WITH_DEFAULT, (void*)(&value));
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x00057554 File Offset: 0x00055754
		// (set) Token: 0x06001039 RID: 4153 RVA: 0x00006D26 File Offset: 0x00004F26
		public unsafe static int WEIGHT_BOOL_TO_STRING
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_BOOL_TO_STRING, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_BOOL_TO_STRING, (void*)(&value));
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x00057570 File Offset: 0x00055770
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x00006D34 File Offset: 0x00004F34
		public unsafe static int WEIGHT_NUMBER_TO_STRING
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NUMBER_TO_STRING, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NUMBER_TO_STRING, (void*)(&value));
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x0005758C File Offset: 0x0005578C
		// (set) Token: 0x0600103D RID: 4157 RVA: 0x00006D42 File Offset: 0x00004F42
		public unsafe static int WEIGHT_NUMBER_TO_ENUM
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NUMBER_TO_ENUM, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NUMBER_TO_ENUM, (void*)(&value));
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x000575A8 File Offset: 0x000557A8
		// (set) Token: 0x0600103F RID: 4159 RVA: 0x00006D50 File Offset: 0x00004F50
		public unsafe static int WEIGHT_USERDATA_TO_STRING
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_USERDATA_TO_STRING, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_USERDATA_TO_STRING, (void*)(&value));
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x000575C4 File Offset: 0x000557C4
		// (set) Token: 0x06001041 RID: 4161 RVA: 0x00006D5E File Offset: 0x00004F5E
		public unsafe static int WEIGHT_TABLE_CONVERSION
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_TABLE_CONVERSION, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_TABLE_CONVERSION, (void*)(&value));
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x000575E0 File Offset: 0x000557E0
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x00006D6C File Offset: 0x00004F6C
		public unsafe static int WEIGHT_NUMBER_DOWNCAST
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NUMBER_DOWNCAST, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NUMBER_DOWNCAST, (void*)(&value));
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x000575FC File Offset: 0x000557FC
		// (set) Token: 0x06001045 RID: 4165 RVA: 0x00006D7A File Offset: 0x00004F7A
		public unsafe static int WEIGHT_NO_MATCH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NO_MATCH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NO_MATCH, (void*)(&value));
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x00057618 File Offset: 0x00055818
		// (set) Token: 0x06001047 RID: 4167 RVA: 0x00006D88 File Offset: 0x00004F88
		public unsafe static int WEIGHT_NO_EXTRA_PARAMS_BONUS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NO_EXTRA_PARAMS_BONUS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_NO_EXTRA_PARAMS_BONUS, (void*)(&value));
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x00057634 File Offset: 0x00055834
		// (set) Token: 0x06001049 RID: 4169 RVA: 0x00006D96 File Offset: 0x00004F96
		public unsafe static int WEIGHT_EXTRA_PARAMS_MALUS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_EXTRA_PARAMS_MALUS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_EXTRA_PARAMS_MALUS, (void*)(&value));
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x00057650 File Offset: 0x00055850
		// (set) Token: 0x0600104B RID: 4171 RVA: 0x00006DA4 File Offset: 0x00004FA4
		public unsafe static int WEIGHT_BYREF_BONUSMALUS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_BYREF_BONUSMALUS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_BYREF_BONUSMALUS, (void*)(&value));
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x0005766C File Offset: 0x0005586C
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x00006DB2 File Offset: 0x00004FB2
		public unsafe static int WEIGHT_VARARGS_MALUS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_VARARGS_MALUS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_VARARGS_MALUS, (void*)(&value));
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x00057688 File Offset: 0x00055888
		// (set) Token: 0x0600104F RID: 4175 RVA: 0x00006DC0 File Offset: 0x00004FC0
		public unsafe static int WEIGHT_VARARGS_EMPTY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_VARARGS_EMPTY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptToClrConversions.NativeFieldInfoPtr_WEIGHT_VARARGS_EMPTY, (void*)(&value));
			}
		}

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_MAX_VALUE;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_CUSTOM_CONVERTER_MATCH;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_EXACT_MATCH;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_STRING_TO_STRINGBUILDER;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_STRING_TO_CHAR;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_NIL_TO_NULLABLE;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_NIL_TO_REFTYPE;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_VOID_WITH_DEFAULT;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_VOID_WITHOUT_DEFAULT;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_NIL_WITH_DEFAULT;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_BOOL_TO_STRING;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_NUMBER_TO_STRING;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_NUMBER_TO_ENUM;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_USERDATA_TO_STRING;

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_TABLE_CONVERSION;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_NUMBER_DOWNCAST;

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_NO_MATCH;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_NO_EXTRA_PARAMS_BONUS;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_EXTRA_PARAMS_MALUS;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_BYREF_BONUSMALUS;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_VARARGS_MALUS;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_VARARGS_EMPTY;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeMethodInfoPtr_DynValueToObject_Internal_Static_Object_DynValue_0;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeMethodInfoPtr_HasImplicitConversion_Public_Static_MethodInfo_Type_Type_0;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeMethodInfoPtr_DynValueToObjectOfType_Internal_Static_Object_DynValue_Type_Object_Boolean_0;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeMethodInfoPtr_DynValueToObjectOfTypeWeight_Internal_Static_Int32_DynValue_Type_Boolean_0;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeMethodInfoPtr_GetNumericTypeWeight_Private_Static_Int32_Type_0;
	}
}
