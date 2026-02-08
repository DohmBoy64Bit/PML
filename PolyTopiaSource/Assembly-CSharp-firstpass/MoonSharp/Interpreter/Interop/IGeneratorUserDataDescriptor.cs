using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x0200009C RID: 156
	public class IGeneratorUserDataDescriptor : Object
	{
		// Token: 0x06000CAD RID: 3245 RVA: 0x00005BD0 File Offset: 0x00003DD0
		// Note: this type is marked as 'beforefieldinit'.
		static IGeneratorUserDataDescriptor()
		{
			Il2CppClassPointerStore<IGeneratorUserDataDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "IGeneratorUserDataDescriptor");
			IGeneratorUserDataDescriptor.NativeMethodInfoPtr_Generate_Public_Abstract_Virtual_New_IUserDataDescriptor_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGeneratorUserDataDescriptor>.NativeClassPtr, 100665504);
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x000477A4 File Offset: 0x000459A4
		[CallerCount(0)]
		public unsafe virtual IUserDataDescriptor Generate(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGeneratorUserDataDescriptor.NativeMethodInfoPtr_Generate_Public_Abstract_Virtual_New_IUserDataDescriptor_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUserDataDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00005BFF File Offset: 0x00003DFF
		public IGeneratorUserDataDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Abstract_Virtual_New_IUserDataDescriptor_Type_0;
	}
}
