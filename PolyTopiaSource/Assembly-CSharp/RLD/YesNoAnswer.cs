using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000118 RID: 280
	public class YesNoAnswer : Object
	{
		// Token: 0x06001AA1 RID: 6817 RVA: 0x00088B80 File Offset: 0x00086D80
		// Note: this type is marked as 'beforefieldinit'.
		static YesNoAnswer()
		{
			Il2CppClassPointerStore<YesNoAnswer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "YesNoAnswer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YesNoAnswer>.NativeClassPtr);
			YesNoAnswer.NativeFieldInfoPtr__hasYes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YesNoAnswer>.NativeClassPtr, "_hasYes");
			YesNoAnswer.NativeFieldInfoPtr__hasNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YesNoAnswer>.NativeClassPtr, "_hasNo");
			YesNoAnswer.NativeMethodInfoPtr_get_HasYes_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YesNoAnswer>.NativeClassPtr, 100667266);
			YesNoAnswer.NativeMethodInfoPtr_get_HasNo_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YesNoAnswer>.NativeClassPtr, 100667267);
			YesNoAnswer.NativeMethodInfoPtr_get_HasOnlyYes_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YesNoAnswer>.NativeClassPtr, 100667268);
			YesNoAnswer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YesNoAnswer>.NativeClassPtr, 100667271);
			YesNoAnswer.NativeMethodInfoPtr_Yes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YesNoAnswer>.NativeClassPtr, 100667269);
			YesNoAnswer.NativeMethodInfoPtr_No_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YesNoAnswer>.NativeClassPtr, 100667270);
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x00088C50 File Offset: 0x00086E50
		public unsafe bool HasYes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YesNoAnswer.NativeMethodInfoPtr_get_HasYes_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06001AA3 RID: 6819 RVA: 0x00088C8C File Offset: 0x00086E8C
		public unsafe bool HasNo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YesNoAnswer.NativeMethodInfoPtr_get_HasNo_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x00088CC8 File Offset: 0x00086EC8
		public unsafe bool HasOnlyYes
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 75909, RefRangeEnd = 75911, XrefRangeStart = 75909, XrefRangeEnd = 75909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YesNoAnswer.NativeMethodInfoPtr_get_HasOnlyYes_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00088D04 File Offset: 0x00086F04
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe YesNoAnswer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YesNoAnswer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YesNoAnswer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x00088D40 File Offset: 0x00086F40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 75911, RefRangeEnd = 75914, XrefRangeStart = 75911, XrefRangeEnd = 75911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Yes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YesNoAnswer.NativeMethodInfoPtr_Yes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00088D74 File Offset: 0x00086F74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 75914, RefRangeEnd = 75917, XrefRangeStart = 75914, XrefRangeEnd = 75914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void No()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YesNoAnswer.NativeMethodInfoPtr_No_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x0000B9DC File Offset: 0x00009BDC
		public YesNoAnswer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x00088DA8 File Offset: 0x00086FA8
		// (set) Token: 0x06001AAA RID: 6826 RVA: 0x0000B9E5 File Offset: 0x00009BE5
		public unsafe bool _hasYes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YesNoAnswer.NativeFieldInfoPtr__hasYes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YesNoAnswer.NativeFieldInfoPtr__hasYes)) = value;
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06001AAB RID: 6827 RVA: 0x00088DD0 File Offset: 0x00086FD0
		// (set) Token: 0x06001AAC RID: 6828 RVA: 0x0000BA00 File Offset: 0x00009C00
		public unsafe bool _hasNo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YesNoAnswer.NativeFieldInfoPtr__hasNo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YesNoAnswer.NativeFieldInfoPtr__hasNo)) = value;
			}
		}

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeFieldInfoPtr__hasYes;

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeFieldInfoPtr__hasNo;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeMethodInfoPtr_get_HasYes_Public_get_Boolean_0;

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNo_Public_get_Boolean_0;

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeMethodInfoPtr_get_HasOnlyYes_Public_get_Boolean_0;

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001450 RID: 5200
		private static readonly IntPtr NativeMethodInfoPtr_Yes_Public_Void_0;

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeMethodInfoPtr_No_Public_Void_0;
	}
}
