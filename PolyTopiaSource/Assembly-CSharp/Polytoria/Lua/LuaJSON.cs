using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SimpleJSON;

namespace Polytoria.Lua
{
	// Token: 0x02000266 RID: 614
	public class LuaJSON : Object
	{
		// Token: 0x06002F58 RID: 12120 RVA: 0x000DA2E0 File Offset: 0x000D84E0
		// Note: this type is marked as 'beforefieldinit'.
		static LuaJSON()
		{
			Il2CppClassPointerStore<LuaJSON>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Lua", "LuaJSON");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuaJSON>.NativeClassPtr);
			LuaJSON.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaJSON>.NativeClassPtr, 100670407);
			LuaJSON.NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaJSON>.NativeClassPtr, 100670405);
			LuaJSON.NativeMethodInfoPtr_GetChildrenAsArray_Public_Static_Il2CppReferenceArray_1_JSONNode_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaJSON>.NativeClassPtr, 100670406);
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x000DA34C File Offset: 0x000D854C
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LuaJSON()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LuaJSON>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaJSON.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x000DA388 File Offset: 0x000D8588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100158, XrefRangeEnd = 100159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JSONNode Parse(string aJSON)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aJSON);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaJSON.NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x000DA3CC File Offset: 0x000D85CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100159, XrefRangeEnd = 100163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<JSONNode> GetChildrenAsArray(JSONNode json)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaJSON.NativeMethodInfoPtr_GetChildrenAsArray_Public_Static_Il2CppReferenceArray_1_JSONNode_JSONNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<JSONNode>>(intPtr3) : null;
			}
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x00012F87 File Offset: 0x00011187
		public LuaJSON(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400242E RID: 9262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400242F RID: 9263
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0;

		// Token: 0x04002430 RID: 9264
		private static readonly IntPtr NativeMethodInfoPtr_GetChildrenAsArray_Public_Static_Il2CppReferenceArray_1_JSONNode_JSONNode_0;
	}
}
