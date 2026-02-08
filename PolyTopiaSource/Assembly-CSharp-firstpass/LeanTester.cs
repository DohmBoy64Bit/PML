using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

// Token: 0x02000008 RID: 8
public class LeanTester : MonoBehaviour
{
	// Token: 0x06000069 RID: 105 RVA: 0x00011EA0 File Offset: 0x000100A0
	// Note: this type is marked as 'beforefieldinit'.
	static LeanTester()
	{
		Il2CppClassPointerStore<LeanTester>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LeanTester");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanTester>.NativeClassPtr);
		LeanTester.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTester>.NativeClassPtr, "timeout");
		LeanTester.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTester>.NativeClassPtr, 100663352);
		LeanTester.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTester>.NativeClassPtr, 100663350);
		LeanTester.NativeMethodInfoPtr_timeoutCheck_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTester>.NativeClassPtr, 100663351);
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00011F20 File Offset: 0x00010120
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10230, XrefRangeEnd = 10231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LeanTester()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanTester>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTester.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00011F5C File Offset: 0x0001015C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10231, XrefRangeEnd = 10237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTester.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00011F90 File Offset: 0x00010190
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10237, XrefRangeEnd = 10242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator timeoutCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTester.NativeMethodInfoPtr_timeoutCheck_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00002211 File Offset: 0x00000411
	public LeanTester(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x0600006E RID: 110 RVA: 0x00011FD0 File Offset: 0x000101D0
	// (set) Token: 0x0600006F RID: 111 RVA: 0x0000221A File Offset: 0x0000041A
	public unsafe float timeout
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTester.NativeFieldInfoPtr_timeout);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTester.NativeFieldInfoPtr_timeout)) = value;
		}
	}

	// Token: 0x04000049 RID: 73
	private static readonly IntPtr NativeFieldInfoPtr_timeout;

	// Token: 0x0400004A RID: 74
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0400004B RID: 75
	private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

	// Token: 0x0400004C RID: 76
	private static readonly IntPtr NativeMethodInfoPtr_timeoutCheck_Private_IEnumerator_0;

	// Token: 0x02000168 RID: 360
	[ObfuscatedName("LeanTester+<timeoutCheck>d__2")]
	public sealed class _timeoutCheck_d__2 : global::Il2CppSystem.Object
	{
		// Token: 0x0600188B RID: 6283 RVA: 0x0007B3AC File Offset: 0x000795AC
		// Note: this type is marked as 'beforefieldinit'.
		static _timeoutCheck_d__2()
		{
			Il2CppClassPointerStore<LeanTester._timeoutCheck_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeanTester>.NativeClassPtr, "<timeoutCheck>d__2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanTester._timeoutCheck_d__2>.NativeClassPtr);
			LeanTester._timeoutCheck_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTester._timeoutCheck_d__2>.NativeClassPtr, "<>1__state");
			LeanTester._timeoutCheck_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTester._timeoutCheck_d__2>.NativeClassPtr, "<>2__current");
			LeanTester._timeoutCheck_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTester._timeoutCheck_d__2>.NativeClassPtr, "<>4__this");
			LeanTester._timeoutCheck_d__2.NativeFieldInfoPtr__pauseEndTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTester._timeoutCheck_d__2>.NativeClassPtr, "<pauseEndTime>5__2");
			LeanTester._timeoutCheck_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTester._timeoutCheck_d__2>.NativeClassPtr, 100663356);
			LeanTester._timeoutCheck_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTester._timeoutCheck_d__2>.NativeClassPtr, 100663358);
			LeanTester._timeoutCheck_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTester._timeoutCheck_d__2>.NativeClassPtr, 100663353);
			LeanTester._timeoutCheck_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTester._timeoutCheck_d__2>.NativeClassPtr, 100663354);
			LeanTester._timeoutCheck_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTester._timeoutCheck_d__2>.NativeClassPtr, 100663355);
			LeanTester._timeoutCheck_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTester._timeoutCheck_d__2>.NativeClassPtr, 100663357);
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x0007B4A0 File Offset: 0x000796A0
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTester._timeoutCheck_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x0007B4E0 File Offset: 0x000796E0
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTester._timeoutCheck_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x0007B520 File Offset: 0x00079720
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10167, XrefRangeEnd = 10168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _timeoutCheck_d__2(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanTester._timeoutCheck_d__2>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTester._timeoutCheck_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0007B568 File Offset: 0x00079768
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTester._timeoutCheck_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0007B59C File Offset: 0x0007979C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10216, XrefRangeEnd = 10225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTester._timeoutCheck_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0007B5D8 File Offset: 0x000797D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10225, XrefRangeEnd = 10230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeanTester._timeoutCheck_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00009ABB File Offset: 0x00007CBB
		public _timeoutCheck_d__2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x0007B60C File Offset: 0x0007980C
		// (set) Token: 0x06001894 RID: 6292 RVA: 0x00009AC4 File Offset: 0x00007CC4
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTester._timeoutCheck_d__2.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTester._timeoutCheck_d__2.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x0007B634 File Offset: 0x00079834
		// (set) Token: 0x06001896 RID: 6294 RVA: 0x00009ADF File Offset: 0x00007CDF
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTester._timeoutCheck_d__2.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTester._timeoutCheck_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x0007B664 File Offset: 0x00079864
		// (set) Token: 0x06001898 RID: 6296 RVA: 0x00009AFE File Offset: 0x00007CFE
		public unsafe LeanTester __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTester._timeoutCheck_d__2.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LeanTester>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTester._timeoutCheck_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001899 RID: 6297 RVA: 0x0007B694 File Offset: 0x00079894
		// (set) Token: 0x0600189A RID: 6298 RVA: 0x00009B1D File Offset: 0x00007D1D
		public unsafe float _pauseEndTime_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTester._timeoutCheck_d__2.NativeFieldInfoPtr__pauseEndTime_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeanTester._timeoutCheck_d__2.NativeFieldInfoPtr__pauseEndTime_5__2)) = value;
			}
		}

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeFieldInfoPtr__pauseEndTime_5__2;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
	}
}
