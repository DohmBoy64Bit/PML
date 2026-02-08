using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Polytoria.Lua
{
	// Token: 0x02000262 RID: 610
	public class LuaEventParameter : PropertyAttribute
	{
		// Token: 0x06002F36 RID: 12086 RVA: 0x00012F0B File Offset: 0x0001110B
		// Note: this type is marked as 'beforefieldinit'.
		static LuaEventParameter()
		{
			Il2CppClassPointerStore<LuaEventParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Lua", "LuaEventParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuaEventParameter>.NativeClassPtr);
			LuaEventParameter.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaEventParameter>.NativeClassPtr, 100670381);
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x000D98FC File Offset: 0x000D7AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LuaEventParameter(Type type, string name, bool nullable = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LuaEventParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaEventParameter.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x00012F44 File Offset: 0x00011144
		public LuaEventParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002415 RID: 9237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_Boolean_0;
	}
}
