using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using UnityEngine;

namespace SimpleJSON
{
	// Token: 0x0200001C RID: 28
	public class JSONNode : global::Il2CppSystem.Object
	{
		// Token: 0x060004D9 RID: 1241 RVA: 0x000263EC File Offset: 0x000245EC
		// Note: this type is marked as 'beforefieldinit'.
		static JSONNode()
		{
			Il2CppClassPointerStore<JSONNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SimpleJSON", "JSONNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONNode>.NativeClassPtr);
			JSONNode.NativeFieldInfoPtr_forceASCII = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, "forceASCII");
			JSONNode.NativeFieldInfoPtr_m_EscapeBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, "m_EscapeBuilder");
			JSONNode.NativeFieldInfoPtr_VectorContainerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, "VectorContainerType");
			JSONNode.NativeFieldInfoPtr_QuaternionContainerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, "QuaternionContainerType");
			JSONNode.NativeFieldInfoPtr_RectContainerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, "RectContainerType");
			JSONNode.NativeMethodInfoPtr_get_Tag_Public_Abstract_Virtual_New_get_JSONNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664162);
			JSONNode.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_JSONNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664163);
			JSONNode.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664164);
			JSONNode.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664165);
			JSONNode.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664166);
			JSONNode.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664167);
			JSONNode.NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664168);
			JSONNode.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664169);
			JSONNode.NativeMethodInfoPtr_get_IsNumber_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664170);
			JSONNode.NativeMethodInfoPtr_get_IsString_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664171);
			JSONNode.NativeMethodInfoPtr_get_IsBoolean_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664172);
			JSONNode.NativeMethodInfoPtr_get_IsNull_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664173);
			JSONNode.NativeMethodInfoPtr_get_IsArray_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664174);
			JSONNode.NativeMethodInfoPtr_get_IsObject_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664175);
			JSONNode.NativeMethodInfoPtr_get_Inline_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664176);
			JSONNode.NativeMethodInfoPtr_set_Inline_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664177);
			JSONNode.NativeMethodInfoPtr_get_Children_Public_Virtual_New_get_IEnumerable_1_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664183);
			JSONNode.NativeMethodInfoPtr_get_DeepChildren_Public_get_IEnumerable_1_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664184);
			JSONNode.NativeMethodInfoPtr_get_Linq_Public_get_IEnumerable_1_KeyValuePair_2_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664189);
			JSONNode.NativeMethodInfoPtr_get_Keys_Public_get_KeyEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664190);
			JSONNode.NativeMethodInfoPtr_get_Values_Public_get_ValueEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664191);
			JSONNode.NativeMethodInfoPtr_get_AsDouble_Public_Virtual_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664192);
			JSONNode.NativeMethodInfoPtr_set_AsDouble_Public_Virtual_New_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664193);
			JSONNode.NativeMethodInfoPtr_get_AsInt_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664194);
			JSONNode.NativeMethodInfoPtr_set_AsInt_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664195);
			JSONNode.NativeMethodInfoPtr_get_AsFloat_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664196);
			JSONNode.NativeMethodInfoPtr_set_AsFloat_Public_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664197);
			JSONNode.NativeMethodInfoPtr_get_AsBool_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664198);
			JSONNode.NativeMethodInfoPtr_set_AsBool_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664199);
			JSONNode.NativeMethodInfoPtr_get_AsArray_Public_Virtual_New_get_JSONArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664200);
			JSONNode.NativeMethodInfoPtr_get_AsObject_Public_Virtual_New_get_JSONObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664201);
			JSONNode.NativeMethodInfoPtr_get_EscapeBuilder_Internal_Static_get_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664217);
			JSONNode.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664256);
			JSONNode.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664178);
			JSONNode.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664179);
			JSONNode.NativeMethodInfoPtr_Remove_Public_Virtual_New_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664180);
			JSONNode.NativeMethodInfoPtr_Remove_Public_Virtual_New_JSONNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664181);
			JSONNode.NativeMethodInfoPtr_Remove_Public_Virtual_New_JSONNode_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664182);
			JSONNode.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664185);
			JSONNode.NativeMethodInfoPtr_ToString_Public_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664186);
			JSONNode.NativeMethodInfoPtr_WriteToStringBuilder_Internal_Abstract_Virtual_New_Void_StringBuilder_Int32_Int32_JSONTextMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664187);
			JSONNode.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_Enumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664188);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664202);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664203);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664204);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_Double_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664205);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664206);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664207);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664208);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664209);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664210);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664211);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_KeyValuePair_2_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664212);
			JSONNode.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_JSONNode_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664213);
			JSONNode.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_JSONNode_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664214);
			JSONNode.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664215);
			JSONNode.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664216);
			JSONNode.NativeMethodInfoPtr_Escape_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664218);
			JSONNode.NativeMethodInfoPtr_ParseElement_Private_Static_Void_JSONNode_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664219);
			JSONNode.NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664220);
			JSONNode.NativeMethodInfoPtr_GetContainer_Private_Static_JSONNode_JSONContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664221);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664222);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664223);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664224);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664225);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664226);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_RectOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664227);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664228);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664229);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664230);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_Quaternion_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664231);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_Rect_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664232);
			JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_RectOffset_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664233);
			JSONNode.NativeMethodInfoPtr_ReadVector2_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664234);
			JSONNode.NativeMethodInfoPtr_ReadVector2_Public_Vector2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664235);
			JSONNode.NativeMethodInfoPtr_ReadVector2_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664236);
			JSONNode.NativeMethodInfoPtr_WriteVector2_Public_JSONNode_Vector2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664237);
			JSONNode.NativeMethodInfoPtr_ReadVector3_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664238);
			JSONNode.NativeMethodInfoPtr_ReadVector3_Public_Vector3_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664239);
			JSONNode.NativeMethodInfoPtr_ReadVector3_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664240);
			JSONNode.NativeMethodInfoPtr_WriteVector3_Public_JSONNode_Vector3_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664241);
			JSONNode.NativeMethodInfoPtr_ReadVector4_Public_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664242);
			JSONNode.NativeMethodInfoPtr_ReadVector4_Public_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664243);
			JSONNode.NativeMethodInfoPtr_WriteVector4_Public_JSONNode_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664244);
			JSONNode.NativeMethodInfoPtr_ReadQuaternion_Public_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664245);
			JSONNode.NativeMethodInfoPtr_ReadQuaternion_Public_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664246);
			JSONNode.NativeMethodInfoPtr_WriteQuaternion_Public_JSONNode_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664247);
			JSONNode.NativeMethodInfoPtr_ReadRect_Public_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664248);
			JSONNode.NativeMethodInfoPtr_ReadRect_Public_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664249);
			JSONNode.NativeMethodInfoPtr_WriteRect_Public_JSONNode_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664250);
			JSONNode.NativeMethodInfoPtr_ReadRectOffset_Public_RectOffset_RectOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664251);
			JSONNode.NativeMethodInfoPtr_ReadRectOffset_Public_RectOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664252);
			JSONNode.NativeMethodInfoPtr_WriteRectOffset_Public_JSONNode_RectOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664253);
			JSONNode.NativeMethodInfoPtr_ReadMatrix_Public_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664254);
			JSONNode.NativeMethodInfoPtr_WriteMatrix_Public_JSONNode_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, 100664255);
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00026BEC File Offset: 0x00024DEC
		public unsafe virtual JSONNodeType Tag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_Tag_Public_Abstract_Virtual_New_get_JSONNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNodeType>(intPtr3) : null;
			}
		}

		// Token: 0x170000FD RID: 253
		public unsafe virtual JSONNode this[int aIndex]
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref aIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_JSONNode_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref aIndex;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000FE RID: 254
		public unsafe virtual JSONNode this[string aKey]
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(aKey);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_JSONNode_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(aKey);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_String_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00026DA8 File Offset: 0x00024FA8
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00026DEC File Offset: 0x00024FEC
		public unsafe virtual string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18230, XrefRangeEnd = 18232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00026E3C File Offset: 0x0002503C
		public unsafe virtual int Count
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00026E84 File Offset: 0x00025084
		public unsafe virtual bool IsNumber
		{
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_IsNumber_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00026ECC File Offset: 0x000250CC
		public unsafe virtual bool IsString
		{
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_IsString_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00026F14 File Offset: 0x00025114
		public unsafe virtual bool IsBoolean
		{
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_IsBoolean_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00026F5C File Offset: 0x0002515C
		public unsafe virtual bool IsNull
		{
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_IsNull_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00026FA4 File Offset: 0x000251A4
		public unsafe virtual bool IsArray
		{
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_IsArray_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00026FEC File Offset: 0x000251EC
		public unsafe virtual bool IsObject
		{
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_IsObject_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00027034 File Offset: 0x00025234
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x0002707C File Offset: 0x0002527C
		public unsafe virtual bool Inline
		{
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_Inline_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_set_Inline_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x000270C8 File Offset: 0x000252C8
		public unsafe virtual IEnumerable<JSONNode> Children
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18358, XrefRangeEnd = 18362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_Children_Public_Virtual_New_get_IEnumerable_1_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JSONNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00027114 File Offset: 0x00025314
		public unsafe IEnumerable<JSONNode> DeepChildren
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18367, RefRangeEnd = 18368, XrefRangeStart = 18362, XrefRangeEnd = 18367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_get_DeepChildren_Public_get_IEnumerable_1_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JSONNode>>(intPtr3) : null;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00027154 File Offset: 0x00025354
		public unsafe IEnumerable<KeyValuePair<string, JSONNode>> Linq
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18368, XrefRangeEnd = 18372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_get_Linq_Public_get_IEnumerable_1_KeyValuePair_2_String_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, JSONNode>>>(intPtr3) : null;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00027194 File Offset: 0x00025394
		public unsafe JSONNode.KeyEnumerator Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18372, XrefRangeEnd = 18373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_get_Keys_Public_get_KeyEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new JSONNode.KeyEnumerator(intPtr);
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x000271CC File Offset: 0x000253CC
		public unsafe JSONNode.ValueEnumerator Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_get_Values_Public_get_ValueEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new JSONNode.ValueEnumerator(intPtr);
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00027204 File Offset: 0x00025404
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x0002724C File Offset: 0x0002544C
		public unsafe virtual double AsDouble
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18373, XrefRangeEnd = 18374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_AsDouble_Public_Virtual_New_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18374, XrefRangeEnd = 18375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_set_AsDouble_Public_Virtual_New_set_Void_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00027298 File Offset: 0x00025498
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x000272E0 File Offset: 0x000254E0
		public unsafe virtual int AsInt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_AsInt_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_set_AsInt_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0002732C File Offset: 0x0002552C
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00027374 File Offset: 0x00025574
		public unsafe virtual float AsFloat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_AsFloat_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_set_AsFloat_Public_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x000273C0 File Offset: 0x000255C0
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00027408 File Offset: 0x00025608
		public unsafe virtual bool AsBool
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18375, XrefRangeEnd = 18379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_AsBool_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18379, XrefRangeEnd = 18384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_set_AsBool_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00027454 File Offset: 0x00025654
		public unsafe virtual JSONArray AsArray
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18384, XrefRangeEnd = 18386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_AsArray_Public_Virtual_New_get_JSONArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x000274A0 File Offset: 0x000256A0
		public unsafe virtual JSONObject AsObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18386, XrefRangeEnd = 18388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_get_AsObject_Public_Virtual_New_get_JSONObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONObject>(intPtr3) : null;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x000274EC File Offset: 0x000256EC
		public unsafe static StringBuilder EscapeBuilder
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18388, XrefRangeEnd = 18402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_get_EscapeBuilder_Internal_Static_get_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00027520 File Offset: 0x00025720
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0002755C File Offset: 0x0002575C
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(string aKey, JSONNode aItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_String_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x000275BC File Offset: 0x000257BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18402, XrefRangeEnd = 18404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(JSONNode aItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aItem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0002760C File Offset: 0x0002580C
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JSONNode Remove(string aKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_Remove_Public_Virtual_New_JSONNode_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00027668 File Offset: 0x00025868
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JSONNode Remove(int aIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_Remove_Public_Virtual_New_JSONNode_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x000276C0 File Offset: 0x000258C0
		[CallerCount(0)]
		public unsafe virtual JSONNode Remove(JSONNode aNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_Remove_Public_Virtual_New_JSONNode_JSONNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0002771C File Offset: 0x0002591C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18404, XrefRangeEnd = 18409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00027760 File Offset: 0x00025960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18409, XrefRangeEnd = 18414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(int aIndent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aIndent;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_ToString_Public_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x000277B0 File Offset: 0x000259B0
		[CallerCount(0)]
		public unsafe virtual void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_WriteToStringBuilder_Internal_Abstract_Virtual_New_Void_StringBuilder_Int32_Int32_JSONTextMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0002782C File Offset: 0x00025A2C
		[CallerCount(0)]
		public unsafe virtual JSONNode.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_Enumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new JSONNode.Enumerator(intPtr);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00027870 File Offset: 0x00025A70
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 18418, RefRangeEnd = 18433, XrefRangeStart = 18414, XrefRangeEnd = 18418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator JSONNode(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x000278B4 File Offset: 0x00025AB4
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 18434, RefRangeEnd = 18481, XrefRangeStart = 18433, XrefRangeEnd = 18434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator string(JSONNode d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_String_JSONNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x000278F0 File Offset: 0x00025AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18481, XrefRangeEnd = 18485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator JSONNode(double n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00027930 File Offset: 0x00025B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18485, XrefRangeEnd = 18486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator double(JSONNode d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_Double_JSONNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00027974 File Offset: 0x00025B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18486, XrefRangeEnd = 18490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator JSONNode(float n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000279B4 File Offset: 0x00025BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18490, XrefRangeEnd = 18491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float(JSONNode d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_JSONNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x000279F8 File Offset: 0x00025BF8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 18495, RefRangeEnd = 18500, XrefRangeStart = 18491, XrefRangeEnd = 18495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator JSONNode(int n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00027A38 File Offset: 0x00025C38
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 18501, RefRangeEnd = 18512, XrefRangeStart = 18500, XrefRangeEnd = 18501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator int(JSONNode d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_JSONNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00027A7C File Offset: 0x00025C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18512, XrefRangeEnd = 18516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator JSONNode(bool b)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00027ABC File Offset: 0x00025CBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 18517, RefRangeEnd = 18520, XrefRangeStart = 18516, XrefRangeEnd = 18517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator bool(JSONNode d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_JSONNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00027B00 File Offset: 0x00025D00
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 18521, RefRangeEnd = 18529, XrefRangeStart = 18520, XrefRangeEnd = 18521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aKeyValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_KeyValuePair_2_String_JSONNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00027B44 File Offset: 0x00025D44
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 18535, RefRangeEnd = 18553, XrefRangeStart = 18529, XrefRangeEnd = 18535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(JSONNode a, global::Il2CppSystem.Object b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_JSONNode_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00027B98 File Offset: 0x00025D98
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 18554, RefRangeEnd = 18562, XrefRangeStart = 18553, XrefRangeEnd = 18554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(JSONNode a, global::Il2CppSystem.Object b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_JSONNode_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00027BEC File Offset: 0x00025DEC
		[CallerCount(1120)]
		[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 19682, XrefRangeStart = 18562, XrefRangeEnd = 18562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(global::Il2CppSystem.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00027C44 File Offset: 0x00025E44
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 19683, RefRangeEnd = 19688, XrefRangeStart = 19682, XrefRangeEnd = 19683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONNode.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00027C8C File Offset: 0x00025E8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19747, RefRangeEnd = 19749, XrefRangeStart = 19688, XrefRangeEnd = 19747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Escape(string aText)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_Escape_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00027CC8 File Offset: 0x00025EC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19766, RefRangeEnd = 19768, XrefRangeStart = 19749, XrefRangeEnd = 19766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ParseElement(JSONNode ctx, string token, string tokenName, bool quoted)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(token);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tokenName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quoted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_ParseElement_Private_Static_Void_JSONNode_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00027D30 File Offset: 0x00025F30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19841, RefRangeEnd = 19842, XrefRangeStart = 19768, XrefRangeEnd = 19841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JSONNode Parse(string aJSON)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aJSON);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00027D74 File Offset: 0x00025F74
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 19847, RefRangeEnd = 19853, XrefRangeStart = 19842, XrefRangeEnd = 19847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JSONNode GetContainer(JSONContainerType aType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_GetContainer_Private_Static_JSONNode_JSONContainerType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00027DB8 File Offset: 0x00025FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19853, XrefRangeEnd = 19861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JSONNode(Vector2 aVec)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aVec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00027DFC File Offset: 0x00025FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19861, XrefRangeEnd = 19871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JSONNode(Vector3 aVec)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aVec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00027E40 File Offset: 0x00026040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19871, XrefRangeEnd = 19875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JSONNode(Vector4 aVec)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aVec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00027E84 File Offset: 0x00026084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19875, XrefRangeEnd = 19879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JSONNode(Quaternion aRot)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aRot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00027EC8 File Offset: 0x000260C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19879, XrefRangeEnd = 19883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JSONNode(Rect aRect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aRect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00027F0C File Offset: 0x0002610C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19883, XrefRangeEnd = 19887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JSONNode(RectOffset aRect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aRect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_RectOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00027F50 File Offset: 0x00026150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19887, XrefRangeEnd = 19889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector2(JSONNode aNode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_JSONNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00027F94 File Offset: 0x00026194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19889, XrefRangeEnd = 19892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector3(JSONNode aNode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_JSONNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00027FD8 File Offset: 0x000261D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19892, XrefRangeEnd = 19895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector4(JSONNode aNode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_JSONNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector4>(intPtr3) : null;
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0002801C File Offset: 0x0002621C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19895, XrefRangeEnd = 19898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Quaternion(JSONNode aNode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_Quaternion_JSONNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00028060 File Offset: 0x00026260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19898, XrefRangeEnd = 19899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Rect(JSONNode aNode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_Rect_JSONNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x000280A4 File Offset: 0x000262A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19899, XrefRangeEnd = 19905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RectOffset(JSONNode aNode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_op_Implicit_Public_Static_RectOffset_JSONNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr3) : null;
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x000280E8 File Offset: 0x000262E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19905, XrefRangeEnd = 19910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 ReadVector2(Vector2 aDefault)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aDefault);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_ReadVector2_Public_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00028138 File Offset: 0x00026338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19910, XrefRangeEnd = 19912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 ReadVector2(string aXName, string aYName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aXName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(aYName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_ReadVector2_Public_Vector2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0002819C File Offset: 0x0002639C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19920, RefRangeEnd = 19921, XrefRangeStart = 19912, XrefRangeEnd = 19920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 ReadVector2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_ReadVector2_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x000281DC File Offset: 0x000263DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19921, XrefRangeEnd = 19922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONNode WriteVector2(Vector2 aVec, string aXName = "x", string aYName = "y")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aVec);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(aXName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(aYName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_WriteVector2_Public_JSONNode_Vector2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00028250 File Offset: 0x00026450
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19930, RefRangeEnd = 19932, XrefRangeStart = 19922, XrefRangeEnd = 19930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ReadVector3(Vector3 aDefault)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aDefault);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_ReadVector3_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x000282A0 File Offset: 0x000264A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19932, XrefRangeEnd = 19935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ReadVector3(string aXName, string aYName, string aZName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aXName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(aYName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(aZName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_ReadVector3_Public_Vector3_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00028314 File Offset: 0x00026514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19935, XrefRangeEnd = 19938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ReadVector3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_ReadVector3_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00028354 File Offset: 0x00026554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19939, RefRangeEnd = 19940, XrefRangeStart = 19938, XrefRangeEnd = 19939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONNode WriteVector3(Vector3 aVec, string aXName = "x", string aYName = "y", string aZName = "z")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aVec);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(aXName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(aYName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(aZName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_WriteVector3_Public_JSONNode_Vector3_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x000283DC File Offset: 0x000265DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19950, RefRangeEnd = 19952, XrefRangeStart = 19940, XrefRangeEnd = 19950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 ReadVector4(Vector4 aDefault)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aDefault);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_ReadVector4_Public_Vector4_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector4>(intPtr3) : null;
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0002842C File Offset: 0x0002662C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19952, XrefRangeEnd = 19955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 ReadVector4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_ReadVector4_Public_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector4>(intPtr3) : null;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0002846C File Offset: 0x0002666C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19964, RefRangeEnd = 19965, XrefRangeStart = 19955, XrefRangeEnd = 19964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONNode WriteVector4(Vector4 aVec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aVec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_WriteVector4_Public_JSONNode_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x000284BC File Offset: 0x000266BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19975, RefRangeEnd = 19977, XrefRangeStart = 19965, XrefRangeEnd = 19975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion ReadQuaternion(Quaternion aDefault)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aDefault);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_ReadQuaternion_Public_Quaternion_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0002850C File Offset: 0x0002670C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19977, XrefRangeEnd = 19980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion ReadQuaternion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_ReadQuaternion_Public_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0002854C File Offset: 0x0002674C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19989, RefRangeEnd = 19990, XrefRangeStart = 19980, XrefRangeEnd = 19989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONNode WriteQuaternion(Quaternion aRot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aRot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_WriteQuaternion_Public_JSONNode_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0002859C File Offset: 0x0002679C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20000, RefRangeEnd = 20002, XrefRangeStart = 19990, XrefRangeEnd = 20000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect ReadRect(Rect aDefault)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aDefault);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_ReadRect_Public_Rect_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
			}
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000285EC File Offset: 0x000267EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20002, XrefRangeEnd = 20003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect ReadRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_ReadRect_Public_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0002862C File Offset: 0x0002682C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20017, RefRangeEnd = 20018, XrefRangeStart = 20003, XrefRangeEnd = 20017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONNode WriteRect(Rect aRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aRect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_WriteRect_Public_JSONNode_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0002867C File Offset: 0x0002687C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20033, RefRangeEnd = 20035, XrefRangeStart = 20018, XrefRangeEnd = 20033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectOffset ReadRectOffset(RectOffset aDefault)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aDefault);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_ReadRectOffset_Public_RectOffset_RectOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr3) : null;
			}
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x000286CC File Offset: 0x000268CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20035, XrefRangeEnd = 20040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectOffset ReadRectOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_ReadRectOffset_Public_RectOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr3) : null;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0002870C File Offset: 0x0002690C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 20056, RefRangeEnd = 20057, XrefRangeStart = 20040, XrefRangeEnd = 20056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONNode WriteRectOffset(RectOffset aRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aRect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_WriteRectOffset_Public_JSONNode_RectOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0002875C File Offset: 0x0002695C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20057, XrefRangeEnd = 20074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 ReadMatrix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_ReadMatrix_Public_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Matrix4x4>(intPtr3) : null;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0002879C File Offset: 0x0002699C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20074, XrefRangeEnd = 20089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONNode WriteMatrix(Matrix4x4 aMatrix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aMatrix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.NativeMethodInfoPtr_WriteMatrix_Public_JSONNode_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0000340D File Offset: 0x0000160D
		public JSONNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x000287EC File Offset: 0x000269EC
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x00003416 File Offset: 0x00001616
		public unsafe static bool forceASCII
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(JSONNode.NativeFieldInfoPtr_forceASCII, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JSONNode.NativeFieldInfoPtr_forceASCII, (void*)(&value));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x00028808 File Offset: 0x00026A08
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x00003424 File Offset: 0x00001624
		public unsafe static StringBuilder m_EscapeBuilder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JSONNode.NativeFieldInfoPtr_m_EscapeBuilder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JSONNode.NativeFieldInfoPtr_m_EscapeBuilder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x00028830 File Offset: 0x00026A30
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x00003436 File Offset: 0x00001636
		public unsafe static JSONContainerType VectorContainerType
		{
			get
			{
				JSONContainerType jsoncontainerType;
				IL2CPP.il2cpp_field_static_get_value(JSONNode.NativeFieldInfoPtr_VectorContainerType, (void*)(&jsoncontainerType));
				return jsoncontainerType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JSONNode.NativeFieldInfoPtr_VectorContainerType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x0002884C File Offset: 0x00026A4C
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x00003448 File Offset: 0x00001648
		public unsafe static JSONContainerType QuaternionContainerType
		{
			get
			{
				JSONContainerType jsoncontainerType;
				IL2CPP.il2cpp_field_static_get_value(JSONNode.NativeFieldInfoPtr_QuaternionContainerType, (void*)(&jsoncontainerType));
				return jsoncontainerType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JSONNode.NativeFieldInfoPtr_QuaternionContainerType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00028868 File Offset: 0x00026A68
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x0000345A File Offset: 0x0000165A
		public unsafe static JSONContainerType RectContainerType
		{
			get
			{
				JSONContainerType jsoncontainerType;
				IL2CPP.il2cpp_field_static_get_value(JSONNode.NativeFieldInfoPtr_RectContainerType, (void*)(&jsoncontainerType));
				return jsoncontainerType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JSONNode.NativeFieldInfoPtr_RectContainerType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeFieldInfoPtr_forceASCII;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeFieldInfoPtr_m_EscapeBuilder;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeFieldInfoPtr_VectorContainerType;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeFieldInfoPtr_QuaternionContainerType;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeFieldInfoPtr_RectContainerType;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_get_Tag_Public_Abstract_Virtual_New_get_JSONNodeType_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_JSONNode_Int32_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_JSONNode_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_JSONNode_String_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_String_JSONNode_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_String_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNumber_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_get_IsString_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBoolean_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_get_IsArray_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_get_IsObject_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_get_Inline_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_set_Inline_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_get_Children_Public_Virtual_New_get_IEnumerable_1_JSONNode_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_get_DeepChildren_Public_get_IEnumerable_1_JSONNode_0;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeMethodInfoPtr_get_Linq_Public_get_IEnumerable_1_KeyValuePair_2_String_JSONNode_0;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_get_KeyEnumerator_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_get_ValueEnumerator_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_get_AsDouble_Public_Virtual_New_get_Double_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_set_AsDouble_Public_Virtual_New_set_Void_Double_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_get_AsInt_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_set_AsInt_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_get_AsFloat_Public_Virtual_New_get_Single_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_set_AsFloat_Public_Virtual_New_set_Void_Single_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr_get_AsBool_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_set_AsBool_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_get_AsArray_Public_Virtual_New_get_JSONArray_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_get_AsObject_Public_Virtual_New_get_JSONObject_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_get_EscapeBuilder_Internal_Static_get_StringBuilder_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Void_String_JSONNode_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Void_JSONNode_0;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_JSONNode_String_0;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_JSONNode_Int32_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_JSONNode_JSONNode_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_New_String_Int32_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_WriteToStringBuilder_Internal_Abstract_Virtual_New_Void_StringBuilder_Int32_Int32_JSONTextMode_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_Enumerator_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_String_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_String_JSONNode_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Double_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Double_JSONNode_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Single_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Single_JSONNode_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Int32_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_JSONNode_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Boolean_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_JSONNode_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_KeyValuePair_2_String_JSONNode_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_JSONNode_Object_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_JSONNode_Object_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_Escape_Internal_Static_String_String_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_ParseElement_Private_Static_Void_JSONNode_String_String_Boolean_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_GetContainer_Private_Static_JSONNode_JSONContainerType_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Vector2_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Vector3_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Vector4_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Quaternion_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_Rect_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JSONNode_RectOffset_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_JSONNode_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_JSONNode_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_JSONNode_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Quaternion_JSONNode_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Rect_JSONNode_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RectOffset_JSONNode_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_ReadVector2_Public_Vector2_Vector2_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_ReadVector2_Public_Vector2_String_String_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_ReadVector2_Public_Vector2_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_WriteVector2_Public_JSONNode_Vector2_String_String_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr_ReadVector3_Public_Vector3_Vector3_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_ReadVector3_Public_Vector3_String_String_String_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_ReadVector3_Public_Vector3_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_WriteVector3_Public_JSONNode_Vector3_String_String_String_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_ReadVector4_Public_Vector4_Vector4_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_ReadVector4_Public_Vector4_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_WriteVector4_Public_JSONNode_Vector4_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_ReadQuaternion_Public_Quaternion_Quaternion_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_ReadQuaternion_Public_Quaternion_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_WriteQuaternion_Public_JSONNode_Quaternion_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_ReadRect_Public_Rect_Rect_0;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_ReadRect_Public_Rect_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_WriteRect_Public_JSONNode_Rect_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr_ReadRectOffset_Public_RectOffset_RectOffset_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_ReadRectOffset_Public_RectOffset_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_WriteRectOffset_Public_JSONNode_RectOffset_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_ReadMatrix_Public_Matrix4x4_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_WriteMatrix_Public_JSONNode_Matrix4x4_0;

		// Token: 0x02000172 RID: 370
		public sealed class Enumerator : ValueType
		{
			// Token: 0x06001919 RID: 6425 RVA: 0x0007CE64 File Offset: 0x0007B064
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<JSONNode.Enumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, "Enumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONNode.Enumerator>.NativeClassPtr);
				JSONNode.Enumerator.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode.Enumerator>.NativeClassPtr, "type");
				JSONNode.Enumerator.NativeFieldInfoPtr_m_Object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode.Enumerator>.NativeClassPtr, "m_Object");
				JSONNode.Enumerator.NativeFieldInfoPtr_m_Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode.Enumerator>.NativeClassPtr, "m_Array");
				JSONNode.Enumerator.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.Enumerator>.NativeClassPtr, 100664257);
				JSONNode.Enumerator.NativeMethodInfoPtr_get_Current_Public_get_KeyValuePair_2_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.Enumerator>.NativeClassPtr, 100664260);
				JSONNode.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_Enumerator_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.Enumerator>.NativeClassPtr, 100664258);
				JSONNode.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_Enumerator_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.Enumerator>.NativeClassPtr, 100664259);
				JSONNode.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.Enumerator>.NativeClassPtr, 100664261);
			}

			// Token: 0x170005B6 RID: 1462
			// (get) Token: 0x0600191A RID: 6426 RVA: 0x0007CF30 File Offset: 0x0007B130
			public unsafe bool IsValid
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.Enumerator.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170005B7 RID: 1463
			// (get) Token: 0x0600191B RID: 6427 RVA: 0x0007CF74 File Offset: 0x0007B174
			public unsafe KeyValuePair<string, JSONNode> Current
			{
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 18041, RefRangeEnd = 18050, XrefRangeStart = 18037, XrefRangeEnd = 18041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.Enumerator.NativeMethodInfoPtr_get_Current_Public_get_KeyValuePair_2_String_JSONNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<KeyValuePair<string, JSONNode>>(intPtr3) : null;
				}
			}

			// Token: 0x0600191C RID: 6428 RVA: 0x0007CFB8 File Offset: 0x0007B1B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18050, XrefRangeEnd = 18051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(List<JSONNode>.Enumerator aArrayEnum)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNode.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(aArrayEnum);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_Enumerator_JSONNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600191D RID: 6429 RVA: 0x0007D008 File Offset: 0x0007B208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18051, XrefRangeEnd = 18052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNode.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(aDictEnum);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_Enumerator_String_JSONNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600191E RID: 6430 RVA: 0x0007D058 File Offset: 0x0007B258
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 18054, RefRangeEnd = 18065, XrefRangeStart = 18052, XrefRangeEnd = 18054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600191F RID: 6431 RVA: 0x00009E65 File Offset: 0x00008065
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001920 RID: 6432 RVA: 0x00009E6E File Offset: 0x0000806E
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNode.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x170005B3 RID: 1459
			// (get) Token: 0x06001921 RID: 6433 RVA: 0x0007D09C File Offset: 0x0007B29C
			// (set) Token: 0x06001922 RID: 6434 RVA: 0x00009E80 File Offset: 0x00008080
			public unsafe JSONNode.Enumerator.Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode.Enumerator.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode.Enumerator.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x170005B4 RID: 1460
			// (get) Token: 0x06001923 RID: 6435 RVA: 0x0007D0C4 File Offset: 0x0007B2C4
			// (set) Token: 0x06001924 RID: 6436 RVA: 0x00009E9B File Offset: 0x0000809B
			public unsafe Dictionary<string, JSONNode>.Enumerator m_Object
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode.Enumerator.NativeFieldInfoPtr_m_Object);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, JSONNode>.Enumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode.Enumerator.NativeFieldInfoPtr_m_Object), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005B5 RID: 1461
			// (get) Token: 0x06001925 RID: 6437 RVA: 0x0007D0F4 File Offset: 0x0007B2F4
			// (set) Token: 0x06001926 RID: 6438 RVA: 0x00009EBA File Offset: 0x000080BA
			public unsafe List<JSONNode>.Enumerator m_Array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode.Enumerator.NativeFieldInfoPtr_m_Array);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<JSONNode>.Enumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode.Enumerator.NativeFieldInfoPtr_m_Array), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014BB RID: 5307
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x040014BC RID: 5308
			private static readonly IntPtr NativeFieldInfoPtr_m_Object;

			// Token: 0x040014BD RID: 5309
			private static readonly IntPtr NativeFieldInfoPtr_m_Array;

			// Token: 0x040014BE RID: 5310
			private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

			// Token: 0x040014BF RID: 5311
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_KeyValuePair_2_String_JSONNode_0;

			// Token: 0x040014C0 RID: 5312
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Enumerator_JSONNode_0;

			// Token: 0x040014C1 RID: 5313
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Enumerator_String_JSONNode_0;

			// Token: 0x040014C2 RID: 5314
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;

			// Token: 0x0200024F RID: 591
			public enum Type
			{
				// Token: 0x04001983 RID: 6531
				None,
				// Token: 0x04001984 RID: 6532
				Array,
				// Token: 0x04001985 RID: 6533
				Object
			}
		}

		// Token: 0x02000173 RID: 371
		public sealed class ValueEnumerator : ValueType
		{
			// Token: 0x06001927 RID: 6439 RVA: 0x0007D124 File Offset: 0x0007B324
			// Note: this type is marked as 'beforefieldinit'.
			static ValueEnumerator()
			{
				Il2CppClassPointerStore<JSONNode.ValueEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, "ValueEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONNode.ValueEnumerator>.NativeClassPtr);
				JSONNode.ValueEnumerator.NativeFieldInfoPtr_m_Enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode.ValueEnumerator>.NativeClassPtr, "m_Enumerator");
				JSONNode.ValueEnumerator.NativeMethodInfoPtr_get_Current_Public_get_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.ValueEnumerator>.NativeClassPtr, 100664265);
				JSONNode.ValueEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Enumerator_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.ValueEnumerator>.NativeClassPtr, 100664262);
				JSONNode.ValueEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Enumerator_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.ValueEnumerator>.NativeClassPtr, 100664263);
				JSONNode.ValueEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Enumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.ValueEnumerator>.NativeClassPtr, 100664264);
				JSONNode.ValueEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.ValueEnumerator>.NativeClassPtr, 100664266);
				JSONNode.ValueEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_ValueEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.ValueEnumerator>.NativeClassPtr, 100664267);
			}

			// Token: 0x170005B9 RID: 1465
			// (get) Token: 0x06001928 RID: 6440 RVA: 0x0007D1DC File Offset: 0x0007B3DC
			public unsafe JSONNode Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18065, XrefRangeEnd = 18070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.ValueEnumerator.NativeMethodInfoPtr_get_Current_Public_get_JSONNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}

			// Token: 0x06001929 RID: 6441 RVA: 0x0007D220 File Offset: 0x0007B420
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18070, XrefRangeEnd = 18072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueEnumerator(List<JSONNode>.Enumerator aArrayEnum)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNode.ValueEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(aArrayEnum);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.ValueEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Enumerator_JSONNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600192A RID: 6442 RVA: 0x0007D270 File Offset: 0x0007B470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18072, XrefRangeEnd = 18074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNode.ValueEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(aDictEnum);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.ValueEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Enumerator_String_JSONNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600192B RID: 6443 RVA: 0x0007D2C0 File Offset: 0x0007B4C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18074, XrefRangeEnd = 18075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueEnumerator(JSONNode.Enumerator aEnumerator)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNode.ValueEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(aEnumerator));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.ValueEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Enumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600192C RID: 6444 RVA: 0x0007D318 File Offset: 0x0007B518
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 18054, RefRangeEnd = 18065, XrefRangeStart = 18054, XrefRangeEnd = 18065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.ValueEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600192D RID: 6445 RVA: 0x0007D35C File Offset: 0x0007B55C
			[CallerCount(0)]
			public unsafe JSONNode.ValueEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.ValueEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_ValueEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new JSONNode.ValueEnumerator(intPtr);
			}

			// Token: 0x0600192E RID: 6446 RVA: 0x00009ED9 File Offset: 0x000080D9
			public ValueEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600192F RID: 6447 RVA: 0x00009EE2 File Offset: 0x000080E2
			public ValueEnumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNode.ValueEnumerator>.NativeClassPtr))
			{
			}

			// Token: 0x170005B8 RID: 1464
			// (get) Token: 0x06001930 RID: 6448 RVA: 0x0007D398 File Offset: 0x0007B598
			// (set) Token: 0x06001931 RID: 6449 RVA: 0x00009EF4 File Offset: 0x000080F4
			public JSONNode.Enumerator m_Enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode.ValueEnumerator.NativeFieldInfoPtr_m_Enumerator);
					return new JSONNode.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JSONNode.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode.ValueEnumerator.NativeFieldInfoPtr_m_Enumerator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<JSONNode.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014C3 RID: 5315
			private static readonly IntPtr NativeFieldInfoPtr_m_Enumerator;

			// Token: 0x040014C4 RID: 5316
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_JSONNode_0;

			// Token: 0x040014C5 RID: 5317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Enumerator_JSONNode_0;

			// Token: 0x040014C6 RID: 5318
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Enumerator_String_JSONNode_0;

			// Token: 0x040014C7 RID: 5319
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Enumerator_0;

			// Token: 0x040014C8 RID: 5320
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;

			// Token: 0x040014C9 RID: 5321
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_ValueEnumerator_0;
		}

		// Token: 0x02000174 RID: 372
		public sealed class KeyEnumerator : ValueType
		{
			// Token: 0x06001932 RID: 6450 RVA: 0x0007D3C8 File Offset: 0x0007B5C8
			// Note: this type is marked as 'beforefieldinit'.
			static KeyEnumerator()
			{
				Il2CppClassPointerStore<JSONNode.KeyEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, "KeyEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONNode.KeyEnumerator>.NativeClassPtr);
				JSONNode.KeyEnumerator.NativeFieldInfoPtr_m_Enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode.KeyEnumerator>.NativeClassPtr, "m_Enumerator");
				JSONNode.KeyEnumerator.NativeMethodInfoPtr_get_Current_Public_get_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.KeyEnumerator>.NativeClassPtr, 100664271);
				JSONNode.KeyEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Enumerator_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.KeyEnumerator>.NativeClassPtr, 100664268);
				JSONNode.KeyEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Enumerator_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.KeyEnumerator>.NativeClassPtr, 100664269);
				JSONNode.KeyEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Enumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.KeyEnumerator>.NativeClassPtr, 100664270);
				JSONNode.KeyEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.KeyEnumerator>.NativeClassPtr, 100664272);
				JSONNode.KeyEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_KeyEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.KeyEnumerator>.NativeClassPtr, 100664273);
			}

			// Token: 0x170005BB RID: 1467
			// (get) Token: 0x06001933 RID: 6451 RVA: 0x0007D480 File Offset: 0x0007B680
			public unsafe JSONNode Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18075, XrefRangeEnd = 18085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.KeyEnumerator.NativeMethodInfoPtr_get_Current_Public_get_JSONNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}

			// Token: 0x06001934 RID: 6452 RVA: 0x0007D4C4 File Offset: 0x0007B6C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyEnumerator(List<JSONNode>.Enumerator aArrayEnum)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNode.KeyEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(aArrayEnum);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.KeyEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Enumerator_JSONNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001935 RID: 6453 RVA: 0x0007D514 File Offset: 0x0007B714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNode.KeyEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(aDictEnum);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.KeyEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Enumerator_String_JSONNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001936 RID: 6454 RVA: 0x0007D564 File Offset: 0x0007B764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyEnumerator(JSONNode.Enumerator aEnumerator)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNode.KeyEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(aEnumerator));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.KeyEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Enumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001937 RID: 6455 RVA: 0x0007D5BC File Offset: 0x0007B7BC
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 18054, RefRangeEnd = 18065, XrefRangeStart = 18054, XrefRangeEnd = 18065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.KeyEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001938 RID: 6456 RVA: 0x0007D600 File Offset: 0x0007B800
			[CallerCount(0)]
			public unsafe JSONNode.KeyEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.KeyEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_KeyEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new JSONNode.KeyEnumerator(intPtr);
			}

			// Token: 0x06001939 RID: 6457 RVA: 0x00009F22 File Offset: 0x00008122
			public KeyEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600193A RID: 6458 RVA: 0x00009F2B File Offset: 0x0000812B
			public KeyEnumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNode.KeyEnumerator>.NativeClassPtr))
			{
			}

			// Token: 0x170005BA RID: 1466
			// (get) Token: 0x0600193B RID: 6459 RVA: 0x0007D63C File Offset: 0x0007B83C
			// (set) Token: 0x0600193C RID: 6460 RVA: 0x00009F3D File Offset: 0x0000813D
			public JSONNode.Enumerator m_Enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode.KeyEnumerator.NativeFieldInfoPtr_m_Enumerator);
					return new JSONNode.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JSONNode.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode.KeyEnumerator.NativeFieldInfoPtr_m_Enumerator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<JSONNode.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014CA RID: 5322
			private static readonly IntPtr NativeFieldInfoPtr_m_Enumerator;

			// Token: 0x040014CB RID: 5323
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_JSONNode_0;

			// Token: 0x040014CC RID: 5324
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Enumerator_JSONNode_0;

			// Token: 0x040014CD RID: 5325
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Enumerator_String_JSONNode_0;

			// Token: 0x040014CE RID: 5326
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Enumerator_0;

			// Token: 0x040014CF RID: 5327
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;

			// Token: 0x040014D0 RID: 5328
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_KeyEnumerator_0;
		}

		// Token: 0x02000175 RID: 373
		public class LinqEnumerator : global::Il2CppSystem.Object
		{
			// Token: 0x0600193D RID: 6461 RVA: 0x0007D66C File Offset: 0x0007B86C
			// Note: this type is marked as 'beforefieldinit'.
			static LinqEnumerator()
			{
				Il2CppClassPointerStore<JSONNode.LinqEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, "LinqEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONNode.LinqEnumerator>.NativeClassPtr);
				JSONNode.LinqEnumerator.NativeFieldInfoPtr_m_Node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode.LinqEnumerator>.NativeClassPtr, "m_Node");
				JSONNode.LinqEnumerator.NativeFieldInfoPtr_m_Enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode.LinqEnumerator>.NativeClassPtr, "m_Enumerator");
				JSONNode.LinqEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.LinqEnumerator>.NativeClassPtr, 100664275);
				JSONNode.LinqEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.LinqEnumerator>.NativeClassPtr, 100664276);
				JSONNode.LinqEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.LinqEnumerator>.NativeClassPtr, 100664274);
				JSONNode.LinqEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.LinqEnumerator>.NativeClassPtr, 100664277);
				JSONNode.LinqEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.LinqEnumerator>.NativeClassPtr, 100664278);
				JSONNode.LinqEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.LinqEnumerator>.NativeClassPtr, 100664279);
				JSONNode.LinqEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.LinqEnumerator>.NativeClassPtr, 100664280);
				JSONNode.LinqEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode.LinqEnumerator>.NativeClassPtr, 100664281);
			}

			// Token: 0x170005BE RID: 1470
			// (get) Token: 0x0600193E RID: 6462 RVA: 0x0007D760 File Offset: 0x0007B960
			public unsafe virtual KeyValuePair<string, JSONNode> Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18085, XrefRangeEnd = 18089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.LinqEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_String_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<KeyValuePair<string, JSONNode>>(intPtr3) : null;
				}
			}

			// Token: 0x170005BF RID: 1471
			// (get) Token: 0x0600193F RID: 6463 RVA: 0x0007D7A0 File Offset: 0x0007B9A0
			public unsafe virtual global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18089, XrefRangeEnd = 18100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.LinqEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001940 RID: 6464 RVA: 0x0007D7E0 File Offset: 0x0007B9E0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 18104, RefRangeEnd = 18107, XrefRangeStart = 18100, XrefRangeEnd = 18104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LinqEnumerator(JSONNode aNode)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNode.LinqEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(aNode);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.LinqEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001941 RID: 6465 RVA: 0x0007D82C File Offset: 0x0007BA2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18107, XrefRangeEnd = 18109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.LinqEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001942 RID: 6466 RVA: 0x0007D868 File Offset: 0x0007BA68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18109, XrefRangeEnd = 18110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.LinqEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001943 RID: 6467 RVA: 0x0007D89C File Offset: 0x0007BA9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18110, XrefRangeEnd = 18114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.LinqEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, JSONNode>>>(intPtr3) : null;
			}

			// Token: 0x06001944 RID: 6468 RVA: 0x0007D8DC File Offset: 0x0007BADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18114, XrefRangeEnd = 18116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.LinqEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001945 RID: 6469 RVA: 0x0007D910 File Offset: 0x0007BB10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18116, XrefRangeEnd = 18120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode.LinqEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001946 RID: 6470 RVA: 0x00009F6B File Offset: 0x0000816B
			public LinqEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005BC RID: 1468
			// (get) Token: 0x06001947 RID: 6471 RVA: 0x0007D950 File Offset: 0x0007BB50
			// (set) Token: 0x06001948 RID: 6472 RVA: 0x00009F74 File Offset: 0x00008174
			public unsafe JSONNode m_Node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode.LinqEnumerator.NativeFieldInfoPtr_m_Node);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode.LinqEnumerator.NativeFieldInfoPtr_m_Node), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005BD RID: 1469
			// (get) Token: 0x06001949 RID: 6473 RVA: 0x0007D980 File Offset: 0x0007BB80
			// (set) Token: 0x0600194A RID: 6474 RVA: 0x00009F93 File Offset: 0x00008193
			public JSONNode.Enumerator m_Enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode.LinqEnumerator.NativeFieldInfoPtr_m_Enumerator);
					return new JSONNode.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JSONNode.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode.LinqEnumerator.NativeFieldInfoPtr_m_Enumerator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<JSONNode.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014D1 RID: 5329
			private static readonly IntPtr NativeFieldInfoPtr_m_Node;

			// Token: 0x040014D2 RID: 5330
			private static readonly IntPtr NativeFieldInfoPtr_m_Enumerator;

			// Token: 0x040014D3 RID: 5331
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_String_JSONNode_0;

			// Token: 0x040014D4 RID: 5332
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040014D5 RID: 5333
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_JSONNode_0;

			// Token: 0x040014D6 RID: 5334
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x040014D7 RID: 5335
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040014D8 RID: 5336
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_JSONNode_0;

			// Token: 0x040014D9 RID: 5337
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x040014DA RID: 5338
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000176 RID: 374
		[ObfuscatedName("SimpleJSON.JSONNode+<get_Children>d__39")]
		public sealed class _get_Children_d__39 : global::Il2CppSystem.Object
		{
			// Token: 0x0600194B RID: 6475 RVA: 0x0007D9B0 File Offset: 0x0007BBB0
			// Note: this type is marked as 'beforefieldinit'.
			static _get_Children_d__39()
			{
				Il2CppClassPointerStore<JSONNode._get_Children_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, "<get_Children>d__39");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONNode._get_Children_d__39>.NativeClassPtr);
				JSONNode._get_Children_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode._get_Children_d__39>.NativeClassPtr, "<>1__state");
				JSONNode._get_Children_d__39.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode._get_Children_d__39>.NativeClassPtr, "<>2__current");
				JSONNode._get_Children_d__39.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode._get_Children_d__39>.NativeClassPtr, "<>l__initialThreadId");
				JSONNode._get_Children_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_SimpleJSON_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_Children_d__39>.NativeClassPtr, 100664285);
				JSONNode._get_Children_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_Children_d__39>.NativeClassPtr, 100664287);
				JSONNode._get_Children_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_Children_d__39>.NativeClassPtr, 100664282);
				JSONNode._get_Children_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_Children_d__39>.NativeClassPtr, 100664283);
				JSONNode._get_Children_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_Children_d__39>.NativeClassPtr, 100664284);
				JSONNode._get_Children_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_Children_d__39>.NativeClassPtr, 100664286);
				JSONNode._get_Children_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_SimpleJSON_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_Children_d__39>.NativeClassPtr, 100664288);
				JSONNode._get_Children_d__39.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_Children_d__39>.NativeClassPtr, 100664289);
			}

			// Token: 0x170005C3 RID: 1475
			// (get) Token: 0x0600194C RID: 6476 RVA: 0x0007DAB8 File Offset: 0x0007BCB8
			public unsafe JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_Children_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_SimpleJSON_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}

			// Token: 0x170005C4 RID: 1476
			// (get) Token: 0x0600194D RID: 6477 RVA: 0x0007DAF8 File Offset: 0x0007BCF8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_Children_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600194E RID: 6478 RVA: 0x0007DB38 File Offset: 0x0007BD38
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 18122, RefRangeEnd = 18124, XrefRangeStart = 18120, XrefRangeEnd = 18122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_Children_d__39(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNode._get_Children_d__39>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_Children_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600194F RID: 6479 RVA: 0x0007DB80 File Offset: 0x0007BD80
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_Children_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001950 RID: 6480 RVA: 0x0007DBB4 File Offset: 0x0007BDB4
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_Children_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001951 RID: 6481 RVA: 0x0007DBF0 File Offset: 0x0007BDF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18124, XrefRangeEnd = 18129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_Children_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001952 RID: 6482 RVA: 0x0007DC24 File Offset: 0x0007BE24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18129, XrefRangeEnd = 18131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<JSONNode> System_Collections_Generic_IEnumerable_SimpleJSON_JSONNode__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_Children_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_SimpleJSON_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JSONNode>>(intPtr3) : null;
			}

			// Token: 0x06001953 RID: 6483 RVA: 0x0007DC64 File Offset: 0x0007BE64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_Children_d__39.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001954 RID: 6484 RVA: 0x00009FC1 File Offset: 0x000081C1
			public _get_Children_d__39(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005C0 RID: 1472
			// (get) Token: 0x06001955 RID: 6485 RVA: 0x0007DCA4 File Offset: 0x0007BEA4
			// (set) Token: 0x06001956 RID: 6486 RVA: 0x00009FCA File Offset: 0x000081CA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_Children_d__39.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_Children_d__39.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005C1 RID: 1473
			// (get) Token: 0x06001957 RID: 6487 RVA: 0x0007DCCC File Offset: 0x0007BECC
			// (set) Token: 0x06001958 RID: 6488 RVA: 0x00009FE5 File Offset: 0x000081E5
			public unsafe JSONNode __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_Children_d__39.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_Children_d__39.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C2 RID: 1474
			// (get) Token: 0x06001959 RID: 6489 RVA: 0x0007DCFC File Offset: 0x0007BEFC
			// (set) Token: 0x0600195A RID: 6490 RVA: 0x0000A004 File Offset: 0x00008204
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_Children_d__39.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_Children_d__39.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040014DB RID: 5339
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014DC RID: 5340
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040014DD RID: 5341
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040014DE RID: 5342
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_SimpleJSON_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0;

			// Token: 0x040014DF RID: 5343
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040014E0 RID: 5344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040014E1 RID: 5345
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014E2 RID: 5346
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040014E3 RID: 5347
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014E4 RID: 5348
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_SimpleJSON_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0;

			// Token: 0x040014E5 RID: 5349
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000177 RID: 375
		[ObfuscatedName("SimpleJSON.JSONNode+<get_DeepChildren>d__41")]
		public sealed class _get_DeepChildren_d__41 : global::Il2CppSystem.Object
		{
			// Token: 0x0600195B RID: 6491 RVA: 0x0007DD24 File Offset: 0x0007BF24
			// Note: this type is marked as 'beforefieldinit'.
			static _get_DeepChildren_d__41()
			{
				Il2CppClassPointerStore<JSONNode._get_DeepChildren_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JSONNode>.NativeClassPtr, "<get_DeepChildren>d__41");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONNode._get_DeepChildren_d__41>.NativeClassPtr);
				JSONNode._get_DeepChildren_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode._get_DeepChildren_d__41>.NativeClassPtr, "<>1__state");
				JSONNode._get_DeepChildren_d__41.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode._get_DeepChildren_d__41>.NativeClassPtr, "<>2__current");
				JSONNode._get_DeepChildren_d__41.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode._get_DeepChildren_d__41>.NativeClassPtr, "<>l__initialThreadId");
				JSONNode._get_DeepChildren_d__41.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode._get_DeepChildren_d__41>.NativeClassPtr, "<>4__this");
				JSONNode._get_DeepChildren_d__41.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode._get_DeepChildren_d__41>.NativeClassPtr, "<>7__wrap1");
				JSONNode._get_DeepChildren_d__41.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONNode._get_DeepChildren_d__41>.NativeClassPtr, "<>7__wrap2");
				JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_SimpleJSON_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChildren_d__41>.NativeClassPtr, 100664295);
				JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChildren_d__41>.NativeClassPtr, 100664297);
				JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChildren_d__41>.NativeClassPtr, 100664290);
				JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChildren_d__41>.NativeClassPtr, 100664291);
				JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChildren_d__41>.NativeClassPtr, 100664292);
				JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChildren_d__41>.NativeClassPtr, 100664293);
				JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChildren_d__41>.NativeClassPtr, 100664294);
				JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChildren_d__41>.NativeClassPtr, 100664296);
				JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_SimpleJSON_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChildren_d__41>.NativeClassPtr, 100664298);
				JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONNode._get_DeepChildren_d__41>.NativeClassPtr, 100664299);
			}

			// Token: 0x170005CB RID: 1483
			// (get) Token: 0x0600195C RID: 6492 RVA: 0x0007DE90 File Offset: 0x0007C090
			public unsafe JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_SimpleJSON_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
				}
			}

			// Token: 0x170005CC RID: 1484
			// (get) Token: 0x0600195D RID: 6493 RVA: 0x0007DED0 File Offset: 0x0007C0D0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600195E RID: 6494 RVA: 0x0007DF10 File Offset: 0x0007C110
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 18122, RefRangeEnd = 18124, XrefRangeStart = 18122, XrefRangeEnd = 18124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_DeepChildren_d__41(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONNode._get_DeepChildren_d__41>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600195F RID: 6495 RVA: 0x0007DF58 File Offset: 0x0007C158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18131, XrefRangeEnd = 18141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001960 RID: 6496 RVA: 0x0007DF8C File Offset: 0x0007C18C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18141, XrefRangeEnd = 18173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001961 RID: 6497 RVA: 0x0007DFC8 File Offset: 0x0007C1C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18173, XrefRangeEnd = 18176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001962 RID: 6498 RVA: 0x0007DFFC File Offset: 0x0007C1FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18176, XrefRangeEnd = 18179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001963 RID: 6499 RVA: 0x0007E030 File Offset: 0x0007C230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18179, XrefRangeEnd = 18184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001964 RID: 6500 RVA: 0x0007E064 File Offset: 0x0007C264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18184, XrefRangeEnd = 18186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<JSONNode> System_Collections_Generic_IEnumerable_SimpleJSON_JSONNode__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_SimpleJSON_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JSONNode>>(intPtr3) : null;
			}

			// Token: 0x06001965 RID: 6501 RVA: 0x0007E0A4 File Offset: 0x0007C2A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONNode._get_DeepChildren_d__41.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001966 RID: 6502 RVA: 0x0000A01F File Offset: 0x0000821F
			public _get_DeepChildren_d__41(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005C5 RID: 1477
			// (get) Token: 0x06001967 RID: 6503 RVA: 0x0007E0E4 File Offset: 0x0007C2E4
			// (set) Token: 0x06001968 RID: 6504 RVA: 0x0000A028 File Offset: 0x00008228
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChildren_d__41.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChildren_d__41.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005C6 RID: 1478
			// (get) Token: 0x06001969 RID: 6505 RVA: 0x0007E10C File Offset: 0x0007C30C
			// (set) Token: 0x0600196A RID: 6506 RVA: 0x0000A043 File Offset: 0x00008243
			public unsafe JSONNode __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChildren_d__41.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChildren_d__41.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C7 RID: 1479
			// (get) Token: 0x0600196B RID: 6507 RVA: 0x0007E13C File Offset: 0x0007C33C
			// (set) Token: 0x0600196C RID: 6508 RVA: 0x0000A062 File Offset: 0x00008262
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChildren_d__41.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChildren_d__41.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005C8 RID: 1480
			// (get) Token: 0x0600196D RID: 6509 RVA: 0x0007E164 File Offset: 0x0007C364
			// (set) Token: 0x0600196E RID: 6510 RVA: 0x0000A07D File Offset: 0x0000827D
			public unsafe JSONNode __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChildren_d__41.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChildren_d__41.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C9 RID: 1481
			// (get) Token: 0x0600196F RID: 6511 RVA: 0x0007E194 File Offset: 0x0007C394
			// (set) Token: 0x06001970 RID: 6512 RVA: 0x0000A09C File Offset: 0x0000829C
			public unsafe IEnumerator<JSONNode> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChildren_d__41.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<JSONNode>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChildren_d__41.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005CA RID: 1482
			// (get) Token: 0x06001971 RID: 6513 RVA: 0x0007E1C4 File Offset: 0x0007C3C4
			// (set) Token: 0x06001972 RID: 6514 RVA: 0x0000A0BB File Offset: 0x000082BB
			public unsafe IEnumerator<JSONNode> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChildren_d__41.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<JSONNode>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONNode._get_DeepChildren_d__41.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014E6 RID: 5350
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014E7 RID: 5351
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040014E8 RID: 5352
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040014E9 RID: 5353
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014EA RID: 5354
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040014EB RID: 5355
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040014EC RID: 5356
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_SimpleJSON_JSONNode__get_Current_Private_Virtual_Final_New_get_JSONNode_0;

			// Token: 0x040014ED RID: 5357
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040014EE RID: 5358
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040014EF RID: 5359
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014F0 RID: 5360
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040014F1 RID: 5361
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040014F2 RID: 5362
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040014F3 RID: 5363
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014F4 RID: 5364
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_SimpleJSON_JSONNode__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JSONNode_0;

			// Token: 0x040014F5 RID: 5365
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
