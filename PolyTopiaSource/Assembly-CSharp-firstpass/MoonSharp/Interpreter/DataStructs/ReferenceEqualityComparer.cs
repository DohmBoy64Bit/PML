using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.DataStructs
{
	// Token: 0x02000106 RID: 262
	public class ReferenceEqualityComparer : Object
	{
		// Token: 0x060013C5 RID: 5061 RVA: 0x00066680 File Offset: 0x00064880
		// Note: this type is marked as 'beforefieldinit'.
		static ReferenceEqualityComparer()
		{
			Il2CppClassPointerStore<ReferenceEqualityComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.DataStructs", "ReferenceEqualityComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReferenceEqualityComparer>.NativeClassPtr);
			ReferenceEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceEqualityComparer>.NativeClassPtr, 100666742);
			ReferenceEqualityComparer.NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_System_Object__Equals_Private_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceEqualityComparer>.NativeClassPtr, 100666740);
			ReferenceEqualityComparer.NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_System_Object__GetHashCode_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceEqualityComparer>.NativeClassPtr, 100666741);
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x000666EC File Offset: 0x000648EC
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReferenceEqualityComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReferenceEqualityComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferenceEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00066728 File Offset: 0x00064928
		[CallerCount(0)]
		public unsafe virtual bool System_Collections_Generic_IEqualityComparer_System_Object__Equals(Object x, Object y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferenceEqualityComparer.NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_System_Object__Equals_Private_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x00066788 File Offset: 0x00064988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46693, XrefRangeEnd = 46694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_Generic_IEqualityComparer_System_Object__GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferenceEqualityComparer.NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_System_Object__GetHashCode_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x000080C3 File Offset: 0x000062C3
		public ReferenceEqualityComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_System_Object__Equals_Private_Virtual_Final_New_Boolean_Object_Object_0;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_System_Object__GetHashCode_Private_Virtual_Final_New_Int32_Object_0;
	}
}
