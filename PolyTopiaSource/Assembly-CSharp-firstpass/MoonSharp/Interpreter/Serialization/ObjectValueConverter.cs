using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Serialization
{
	// Token: 0x02000080 RID: 128
	public static class ObjectValueConverter : Object
	{
		// Token: 0x06000B66 RID: 2918 RVA: 0x0000572A File Offset: 0x0000392A
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectValueConverter()
		{
			Il2CppClassPointerStore<ObjectValueConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Serialization", "ObjectValueConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectValueConverter>.NativeClassPtr);
			ObjectValueConverter.NativeMethodInfoPtr_SerializeObjectToDynValue_Public_Static_DynValue_Script_Object_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectValueConverter>.NativeClassPtr, 100665267);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00041C04 File Offset: 0x0003FE04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 31652, RefRangeEnd = 31655, XrefRangeStart = 31587, XrefRangeEnd = 31652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue SerializeObjectToDynValue(Script script, Object o, DynValue valueForNulls = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueForNulls);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectValueConverter.NativeMethodInfoPtr_SerializeObjectToDynValue_Public_Static_DynValue_Script_Object_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00005763 File Offset: 0x00003963
		public ObjectValueConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeMethodInfoPtr_SerializeObjectToDynValue_Public_Static_DynValue_Script_Object_DynValue_0;
	}
}
