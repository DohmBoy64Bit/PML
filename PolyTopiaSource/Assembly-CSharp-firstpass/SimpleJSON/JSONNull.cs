using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace SimpleJSON
{
	// Token: 0x02000022 RID: 34
	public class JSONNull : JSONNode
	{
		// Token: 0x0600059F RID: 1439 RVA: 0x0002A5B0 File Offset: 0x000287B0
		// Note: this type is marked as 'beforefieldinit'.
		static JSONNull()
		{
			Il2CppClassPointerStore<JSONNull>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SimpleJSON", "JSONNull");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONNull>.NativeClassPtr);
			JSONNull.NativeFieldInfoPtr_m_StaticInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNull>.NativeClassPtr, "m_StaticInstance");
			JSONNull.NativeFieldInfoPtr_reuseSameInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNull>.NativeClassPtr, "reuseSameInstance");
			JSONNull.NativeMethodInfoPtr_get_Tag_Public_Virtual_get_JSONNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNull>.NativeClassPtr, 100664389);
			JSONNull.NativeMethodInfoPtr_get_IsNull_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNull>.NativeClassPtr, 100664390);
			JSONNull.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNull>.NativeClassPtr, 100664392);
			JSONNull.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNull>.NativeClassPtr, 100664393);
			JSONNull.NativeMethodInfoPtr_get_AsBool_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNull>.NativeClassPtr, 100664394);
			JSONNull.NativeMethodInfoPtr_set_AsBool_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNull>.NativeClassPtr, 100664395);
			JSONNull.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNull>.NativeClassPtr, 100664388);
			JSONNull.NativeMethodInfoPtr_CreateOrGet_Public_Static_JSONNull_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNull>.NativeClassPtr, 100664387);
			JSONNull.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Enumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNull>.NativeClassPtr, 100664391);
			JSONNull.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNull>.NativeClassPtr, 100664396);
			JSONNull.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNull>.NativeClassPtr, 100664397);
			JSONNull.NativeMethodInfoPtr_WriteToStringBuilder_Internal_Virtual_Void_StringBuilder_Int32_Int32_JSONTextMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNull>.NativeClassPtr, 100664398);
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0002A6F8 File Offset: 0x000288F8
		public unsafe override JSONNodeType Tag
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20601, RefRangeEnd = 20602, XrefRangeStart = 20601, XrefRangeEnd = 20601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNull.NativeMethodInfoPtr_get_Tag_Public_Virtual_get_JSONNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNodeType>(intPtr3) : null;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0002A744 File Offset: 0x00028944
		public unsafe override bool IsNull
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNull.NativeMethodInfoPtr_get_IsNull_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0002A78C File Offset: 0x0002898C
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x0002A7D0 File Offset: 0x000289D0
		public unsafe override string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20602, XrefRangeEnd = 20604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNull.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNull.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x0002A820 File Offset: 0x00028A20
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x0002A868 File Offset: 0x00028A68
		public unsafe override bool AsBool
		{
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNull.NativeMethodInfoPtr_get_AsBool_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNull.NativeMethodInfoPtr_set_AsBool_Public_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0002A8B4 File Offset: 0x00028AB4
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 20605, RefRangeEnd = 20668, XrefRangeStart = 20604, XrefRangeEnd = 20605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONNull()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNull>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNull.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0002A8F0 File Offset: 0x00028AF0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 20674, RefRangeEnd = 20680, XrefRangeStart = 20668, XrefRangeEnd = 20674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JSONNull CreateOrGet()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNull.NativeMethodInfoPtr_CreateOrGet_Public_Static_JSONNull_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNull>(intPtr3) : null;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0002A924 File Offset: 0x00028B24
		[CallerCount(0)]
		public unsafe override JSONNode.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNull.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Enumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new JSONNode.Enumerator(intPtr);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0002A968 File Offset: 0x00028B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20680, XrefRangeEnd = 20682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNull.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0002A9C0 File Offset: 0x00028BC0
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNull.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0002AA08 File Offset: 0x00028C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20682, XrefRangeEnd = 20694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aSB);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aIndent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aIndentInc;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aMode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNull.NativeMethodInfoPtr_WriteToStringBuilder_Internal_Virtual_Void_StringBuilder_Int32_Int32_JSONTextMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00003562 File Offset: 0x00001762
		public JSONNull(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0002AA84 File Offset: 0x00028C84
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x0000356B File Offset: 0x0000176B
		public unsafe static JSONNull m_StaticInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JSONNull.NativeFieldInfoPtr_m_StaticInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNull>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JSONNull.NativeFieldInfoPtr_m_StaticInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0002AAAC File Offset: 0x00028CAC
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x0000357D File Offset: 0x0000177D
		public unsafe static bool reuseSameInstance
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(JSONNull.NativeFieldInfoPtr_reuseSameInstance, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JSONNull.NativeFieldInfoPtr_reuseSameInstance, (void*)(&value));
			}
		}

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeFieldInfoPtr_m_StaticInstance;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeFieldInfoPtr_reuseSameInstance;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_get_Tag_Public_Virtual_get_JSONNodeType_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_Virtual_get_Boolean_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_get_AsBool_Public_Virtual_get_Boolean_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_set_AsBool_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_CreateOrGet_Public_Static_JSONNull_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Enumerator_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_WriteToStringBuilder_Internal_Virtual_Void_StringBuilder_Int32_Int32_JSONTextMode_0;
	}
}
