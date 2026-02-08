using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200003C RID: 60
	public class YieldRequest : Object
	{
		// Token: 0x06000797 RID: 1943 RVA: 0x00032BE4 File Offset: 0x00030DE4
		// Note: this type is marked as 'beforefieldinit'.
		static YieldRequest()
		{
			Il2CppClassPointerStore<YieldRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "YieldRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YieldRequest>.NativeClassPtr);
			YieldRequest.NativeFieldInfoPtr_ReturnValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldRequest>.NativeClassPtr, "ReturnValues");
			YieldRequest.NativeFieldInfoPtr__Forced_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldRequest>.NativeClassPtr, "<Forced>k__BackingField");
			YieldRequest.NativeMethodInfoPtr_get_Forced_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldRequest>.NativeClassPtr, 100664754);
			YieldRequest.NativeMethodInfoPtr_set_Forced_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldRequest>.NativeClassPtr, 100664755);
			YieldRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldRequest>.NativeClassPtr, 100664756);
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00032C78 File Offset: 0x00030E78
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x00032CB4 File Offset: 0x00030EB4
		public unsafe bool Forced
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YieldRequest.NativeMethodInfoPtr_get_Forced_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YieldRequest.NativeMethodInfoPtr_set_Forced_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00032CF4 File Offset: 0x00030EF4
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe YieldRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YieldRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YieldRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00003E64 File Offset: 0x00002064
		public YieldRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00032D30 File Offset: 0x00030F30
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x00003E6D File Offset: 0x0000206D
		public unsafe Il2CppReferenceArray<DynValue> ReturnValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YieldRequest.NativeFieldInfoPtr_ReturnValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YieldRequest.NativeFieldInfoPtr_ReturnValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x00032D60 File Offset: 0x00030F60
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00003E8C File Offset: 0x0000208C
		public unsafe bool _Forced_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YieldRequest.NativeFieldInfoPtr__Forced_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YieldRequest.NativeFieldInfoPtr__Forced_k__BackingField)) = value;
			}
		}

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeFieldInfoPtr_ReturnValues;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeFieldInfoPtr__Forced_k__BackingField;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_get_Forced_Public_get_Boolean_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_set_Forced_Internal_set_Void_Boolean_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
