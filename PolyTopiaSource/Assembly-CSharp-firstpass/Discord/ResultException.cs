using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Discord
{
	// Token: 0x02000158 RID: 344
	public class ResultException : Exception
	{
		// Token: 0x060016BB RID: 5819 RVA: 0x0007394C File Offset: 0x00071B4C
		// Note: this type is marked as 'beforefieldinit'.
		static ResultException()
		{
			Il2CppClassPointerStore<ResultException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "ResultException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultException>.NativeClassPtr);
			ResultException.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultException>.NativeClassPtr, "Result");
			ResultException.NativeMethodInfoPtr__ctor_Public_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultException>.NativeClassPtr, 100667380);
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x000739A4 File Offset: 0x00071BA4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 52276, RefRangeEnd = 52282, XrefRangeStart = 52269, XrefRangeEnd = 52276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResultException(Result result)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResultException.NativeMethodInfoPtr__ctor_Public_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00008FB1 File Offset: 0x000071B1
		public ResultException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x000739F0 File Offset: 0x00071BF0
		// (set) Token: 0x060016BF RID: 5823 RVA: 0x00008FBA File Offset: 0x000071BA
		public unsafe Result Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultException.NativeFieldInfoPtr_Result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Result>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResultException.NativeFieldInfoPtr_Result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012FE RID: 4862
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040012FF RID: 4863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Result_0;
	}
}
