using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace SimpleJSON
{
	// Token: 0x02000020 RID: 32
	public class JSONNumber : JSONNode
	{
		// Token: 0x0600057E RID: 1406 RVA: 0x00029B40 File Offset: 0x00027D40
		// Note: this type is marked as 'beforefieldinit'.
		static JSONNumber()
		{
			Il2CppClassPointerStore<JSONNumber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SimpleJSON", "JSONNumber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONNumber>.NativeClassPtr);
			JSONNumber.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNumber>.NativeClassPtr, "m_Data");
			JSONNumber.NativeMethodInfoPtr_get_Tag_Public_Virtual_get_JSONNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNumber>.NativeClassPtr, 100664362);
			JSONNumber.NativeMethodInfoPtr_get_IsNumber_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNumber>.NativeClassPtr, 100664363);
			JSONNumber.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNumber>.NativeClassPtr, 100664365);
			JSONNumber.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNumber>.NativeClassPtr, 100664366);
			JSONNumber.NativeMethodInfoPtr_get_AsDouble_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNumber>.NativeClassPtr, 100664367);
			JSONNumber.NativeMethodInfoPtr_set_AsDouble_Public_Virtual_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNumber>.NativeClassPtr, 100664368);
			JSONNumber.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNumber>.NativeClassPtr, 100664369);
			JSONNumber.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNumber>.NativeClassPtr, 100664370);
			JSONNumber.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Enumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNumber>.NativeClassPtr, 100664364);
			JSONNumber.NativeMethodInfoPtr_WriteToStringBuilder_Internal_Virtual_Void_StringBuilder_Int32_Int32_JSONTextMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNumber>.NativeClassPtr, 100664371);
			JSONNumber.NativeMethodInfoPtr_IsNumeric_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNumber>.NativeClassPtr, 100664372);
			JSONNumber.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNumber>.NativeClassPtr, 100664373);
			JSONNumber.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNumber>.NativeClassPtr, 100664374);
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00029C88 File Offset: 0x00027E88
		public unsafe override JSONNodeType Tag
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20535, RefRangeEnd = 20538, XrefRangeStart = 20535, XrefRangeEnd = 20535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNumber.NativeMethodInfoPtr_get_Tag_Public_Virtual_get_JSONNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNodeType>(intPtr3) : null;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x00029CD4 File Offset: 0x00027ED4
		public unsafe override bool IsNumber
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNumber.NativeMethodInfoPtr_get_IsNumber_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00029D1C File Offset: 0x00027F1C
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00029D60 File Offset: 0x00027F60
		public unsafe override string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20538, XrefRangeEnd = 20539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNumber.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20539, XrefRangeEnd = 20540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNumber.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00029DB0 File Offset: 0x00027FB0
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00029DF8 File Offset: 0x00027FF8
		public unsafe override double AsDouble
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNumber.NativeMethodInfoPtr_get_AsDouble_Public_Virtual_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNumber.NativeMethodInfoPtr_set_AsDouble_Public_Virtual_set_Void_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00029E44 File Offset: 0x00028044
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 20541, RefRangeEnd = 20546, XrefRangeStart = 20540, XrefRangeEnd = 20541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONNumber(double aData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNumber>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNumber.NativeMethodInfoPtr__ctor_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00029E8C File Offset: 0x0002808C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20546, XrefRangeEnd = 20547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONNumber(string aData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNumber>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNumber.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00029ED8 File Offset: 0x000280D8
		[CallerCount(0)]
		public unsafe override JSONNode.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNumber.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Enumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new JSONNode.Enumerator(intPtr);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00029F1C File Offset: 0x0002811C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20547, XrefRangeEnd = 20549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNumber.NativeMethodInfoPtr_WriteToStringBuilder_Internal_Virtual_Void_StringBuilder_Int32_Int32_JSONTextMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00029F98 File Offset: 0x00028198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20549, XrefRangeEnd = 20561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNumeric(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNumber.NativeMethodInfoPtr_IsNumeric_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00029FDC File Offset: 0x000281DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20561, XrefRangeEnd = 20581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNumber.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0002A034 File Offset: 0x00028234
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNumber.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0000351A File Offset: 0x0000171A
		public JSONNumber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x0002A07C File Offset: 0x0002827C
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00003523 File Offset: 0x00001723
		public unsafe double m_Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNumber.NativeFieldInfoPtr_m_Data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNumber.NativeFieldInfoPtr_m_Data)) = value;
			}
		}

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeFieldInfoPtr_m_Data;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_get_Tag_Public_Virtual_get_JSONNodeType_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNumber_Public_Virtual_get_Boolean_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_get_AsDouble_Public_Virtual_get_Double_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_set_AsDouble_Public_Virtual_set_Void_Double_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Enumerator_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_WriteToStringBuilder_Internal_Virtual_Void_StringBuilder_Int32_Int32_JSONTextMode_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_IsNumeric_Private_Static_Boolean_Object_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
