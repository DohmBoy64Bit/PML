using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors
{
	// Token: 0x020000C4 RID: 196
	public class HardwiredUserDataDescriptor : DispatchingUserDataDescriptor
	{
		// Token: 0x06000F34 RID: 3892 RVA: 0x000069CC File Offset: 0x00004BCC
		// Note: this type is marked as 'beforefieldinit'.
		static HardwiredUserDataDescriptor()
		{
			Il2CppClassPointerStore<HardwiredUserDataDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors", "HardwiredUserDataDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardwiredUserDataDescriptor>.NativeClassPtr);
			HardwiredUserDataDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwiredUserDataDescriptor>.NativeClassPtr, 100666031);
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x00052CC0 File Offset: 0x00050EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39638, XrefRangeEnd = 39658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HardwiredUserDataDescriptor(Type T)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardwiredUserDataDescriptor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(T);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwiredUserDataDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00006A05 File Offset: 0x00004C05
		public HardwiredUserDataDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Type_0;
	}
}
