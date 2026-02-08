using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Serialization.Json
{
	// Token: 0x02000082 RID: 130
	public sealed class JsonNull : Object
	{
		// Token: 0x06000B71 RID: 2929 RVA: 0x00041E4C File Offset: 0x0004004C
		// Note: this type is marked as 'beforefieldinit'.
		static JsonNull()
		{
			Il2CppClassPointerStore<JsonNull>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Serialization.Json", "JsonNull");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonNull>.NativeClassPtr);
			JsonNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonNull>.NativeClassPtr, 100665276);
			JsonNull.NativeMethodInfoPtr_isNull_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonNull>.NativeClassPtr, 100665273);
			JsonNull.NativeMethodInfoPtr_IsJsonNull_Public_Static_Boolean_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonNull>.NativeClassPtr, 100665274);
			JsonNull.NativeMethodInfoPtr_Create_Public_Static_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonNull>.NativeClassPtr, 100665275);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00041ECC File Offset: 0x000400CC
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonNull()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonNull>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00041F08 File Offset: 0x00040108
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isNull()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonNull.NativeMethodInfoPtr_isNull_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00041F38 File Offset: 0x00040138
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31835, RefRangeEnd = 31836, XrefRangeStart = 31823, XrefRangeEnd = 31835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsJsonNull(DynValue v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonNull.NativeMethodInfoPtr_IsJsonNull_Public_Static_Boolean_DynValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00041F7C File Offset: 0x0004017C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 31842, RefRangeEnd = 31844, XrefRangeStart = 31836, XrefRangeEnd = 31842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonNull.NativeMethodInfoPtr_Create_Public_Static_DynValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00005787 File Offset: 0x00003987
		public JsonNull(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr_isNull_Public_Static_Boolean_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr_IsJsonNull_Public_Static_Boolean_DynValue_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_DynValue_0;
	}
}
