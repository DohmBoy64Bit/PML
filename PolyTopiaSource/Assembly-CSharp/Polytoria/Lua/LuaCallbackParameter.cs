using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Polytoria.Lua
{
	// Token: 0x02000261 RID: 609
	public class LuaCallbackParameter : PropertyAttribute
	{
		// Token: 0x06002F33 RID: 12083 RVA: 0x00012EC9 File Offset: 0x000110C9
		// Note: this type is marked as 'beforefieldinit'.
		static LuaCallbackParameter()
		{
			Il2CppClassPointerStore<LuaCallbackParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Lua", "LuaCallbackParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuaCallbackParameter>.NativeClassPtr);
			LuaCallbackParameter.NativeMethodInfoPtr__ctor_Public_Void_String_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaCallbackParameter>.NativeClassPtr, 100670380);
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x000D987C File Offset: 0x000D7A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99975, XrefRangeEnd = 99976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LuaCallbackParameter(string callback, Type type, string name, bool nullable = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LuaCallbackParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaCallbackParameter.NativeMethodInfoPtr__ctor_Public_Void_String_Type_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x00012F02 File Offset: 0x00011102
		public LuaCallbackParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002414 RID: 9236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Type_String_Boolean_0;
	}
}
