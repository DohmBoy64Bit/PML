using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop.RegistrationPolicies
{
	// Token: 0x020000C5 RID: 197
	public class AutomaticRegistrationPolicy : DefaultRegistrationPolicy
	{
		// Token: 0x06000F37 RID: 3895 RVA: 0x00052D0C File Offset: 0x00050F0C
		// Note: this type is marked as 'beforefieldinit'.
		static AutomaticRegistrationPolicy()
		{
			Il2CppClassPointerStore<AutomaticRegistrationPolicy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.RegistrationPolicies", "AutomaticRegistrationPolicy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutomaticRegistrationPolicy>.NativeClassPtr);
			AutomaticRegistrationPolicy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticRegistrationPolicy>.NativeClassPtr, 100666033);
			AutomaticRegistrationPolicy.NativeMethodInfoPtr_AllowTypeAutoRegistration_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticRegistrationPolicy>.NativeClassPtr, 100666032);
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x00052D64 File Offset: 0x00050F64
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutomaticRegistrationPolicy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutomaticRegistrationPolicy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticRegistrationPolicy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00052DA0 File Offset: 0x00050FA0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool AllowTypeAutoRegistration(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutomaticRegistrationPolicy.NativeMethodInfoPtr_AllowTypeAutoRegistration_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00006A0E File Offset: 0x00004C0E
		public AutomaticRegistrationPolicy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr_AllowTypeAutoRegistration_Public_Virtual_Boolean_Type_0;
	}
}
