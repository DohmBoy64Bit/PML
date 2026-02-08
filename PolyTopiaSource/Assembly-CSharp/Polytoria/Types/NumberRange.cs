using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Polytoria.Types
{
	// Token: 0x0200025D RID: 605
	[StructLayout(2)]
	public struct NumberRange
	{
		// Token: 0x06002ED8 RID: 11992 RVA: 0x000D7F64 File Offset: 0x000D6164
		// Note: this type is marked as 'beforefieldinit'.
		static NumberRange()
		{
			Il2CppClassPointerStore<NumberRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Types", "NumberRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberRange>.NativeClassPtr);
			NumberRange.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberRange>.NativeClassPtr, "min");
			NumberRange.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberRange>.NativeClassPtr, "max");
			NumberRange.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberRange>.NativeClassPtr, 100670290);
			NumberRange.NativeMethodInfoPtr_Lerp_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberRange>.NativeClassPtr, 100670291);
			NumberRange.NativeMethodInfoPtr_New_Public_Static_NumberRange_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberRange>.NativeClassPtr, 100670292);
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x000D7FF8 File Offset: 0x000D61F8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 99269, RefRangeEnd = 99278, XrefRangeStart = 99269, XrefRangeEnd = 99269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberRange(float min, float max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberRange.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x000D8038 File Offset: 0x000D6238
		[CallerCount(0)]
		public unsafe float Lerp(float t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberRange.NativeMethodInfoPtr_Lerp_Public_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x000D8078 File Offset: 0x000D6278
		[CallerCount(0)]
		public unsafe static NumberRange New(float min, float max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberRange.NativeMethodInfoPtr_New_Public_Static_NumberRange_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr3) : null;
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x00012D5A File Offset: 0x00010F5A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NumberRange>.NativeClassPtr, ref this));
		}

		// Token: 0x040023C9 RID: 9161
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x040023CA RID: 9162
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x040023CB RID: 9163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x040023CC RID: 9164
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Single_Single_0;

		// Token: 0x040023CD RID: 9165
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_NumberRange_Single_Single_0;

		// Token: 0x040023CE RID: 9166
		[FieldOffset(0)]
		public float min;

		// Token: 0x040023CF RID: 9167
		[FieldOffset(4)]
		public float max;
	}
}
