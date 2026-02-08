using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Controllers
{
	// Token: 0x02000321 RID: 801
	public class AbuseReportController : MonoBehaviour
	{
		// Token: 0x0600446F RID: 17519 RVA: 0x00132C88 File Offset: 0x00130E88
		// Note: this type is marked as 'beforefieldinit'.
		static AbuseReportController()
		{
			Il2CppClassPointerStore<AbuseReportController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "AbuseReportController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbuseReportController>.NativeClassPtr);
			AbuseReportController.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbuseReportController>.NativeClassPtr, "input");
			AbuseReportController.NativeFieldInfoPtr_defaultPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbuseReportController>.NativeClassPtr, "defaultPanel");
			AbuseReportController.NativeFieldInfoPtr_finishedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbuseReportController>.NativeClassPtr, "finishedPanel");
			AbuseReportController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbuseReportController>.NativeClassPtr, 100674120);
			AbuseReportController.NativeMethodInfoPtr_Submit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbuseReportController>.NativeClassPtr, 100674116);
			AbuseReportController.NativeMethodInfoPtr_Return_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbuseReportController>.NativeClassPtr, 100674117);
			AbuseReportController.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbuseReportController>.NativeClassPtr, 100674118);
			AbuseReportController.NativeMethodInfoPtr_SubmitAbuseReport_Private_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbuseReportController>.NativeClassPtr, 100674119);
		}

		// Token: 0x06004470 RID: 17520 RVA: 0x00132D58 File Offset: 0x00130F58
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbuseReportController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbuseReportController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbuseReportController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004471 RID: 17521 RVA: 0x00132D94 File Offset: 0x00130F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130560, XrefRangeEnd = 130576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Submit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbuseReportController.NativeMethodInfoPtr_Submit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004472 RID: 17522 RVA: 0x00132DC8 File Offset: 0x00130FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130576, XrefRangeEnd = 130584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Return()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbuseReportController.NativeMethodInfoPtr_Return_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004473 RID: 17523 RVA: 0x00132DFC File Offset: 0x00130FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130584, XrefRangeEnd = 130595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbuseReportController.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x00132E30 File Offset: 0x00131030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130595, XrefRangeEnd = 130600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SubmitAbuseReport(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbuseReportController.NativeMethodInfoPtr_SubmitAbuseReport_Private_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x00019329 File Offset: 0x00017529
		public AbuseReportController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x06004476 RID: 17526 RVA: 0x00132E80 File Offset: 0x00131080
		// (set) Token: 0x06004477 RID: 17527 RVA: 0x00019332 File Offset: 0x00017532
		public unsafe TMP_InputField input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbuseReportController.NativeFieldInfoPtr_input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbuseReportController.NativeFieldInfoPtr_input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x06004478 RID: 17528 RVA: 0x00132EB0 File Offset: 0x001310B0
		// (set) Token: 0x06004479 RID: 17529 RVA: 0x00019351 File Offset: 0x00017551
		public unsafe RectTransform defaultPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbuseReportController.NativeFieldInfoPtr_defaultPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbuseReportController.NativeFieldInfoPtr_defaultPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x0600447A RID: 17530 RVA: 0x00132EE0 File Offset: 0x001310E0
		// (set) Token: 0x0600447B RID: 17531 RVA: 0x00019370 File Offset: 0x00017570
		public unsafe RectTransform finishedPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbuseReportController.NativeFieldInfoPtr_finishedPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbuseReportController.NativeFieldInfoPtr_finishedPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400353C RID: 13628
		private static readonly IntPtr NativeFieldInfoPtr_input;

		// Token: 0x0400353D RID: 13629
		private static readonly IntPtr NativeFieldInfoPtr_defaultPanel;

		// Token: 0x0400353E RID: 13630
		private static readonly IntPtr NativeFieldInfoPtr_finishedPanel;

		// Token: 0x0400353F RID: 13631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003540 RID: 13632
		private static readonly IntPtr NativeMethodInfoPtr_Submit_Public_Void_0;

		// Token: 0x04003541 RID: 13633
		private static readonly IntPtr NativeMethodInfoPtr_Return_Public_Void_0;

		// Token: 0x04003542 RID: 13634
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x04003543 RID: 13635
		private static readonly IntPtr NativeMethodInfoPtr_SubmitAbuseReport_Private_IEnumerator_String_0;

		// Token: 0x0200041F RID: 1055
		[ObfuscatedName("Polytoria.Controllers.AbuseReportController+<SubmitAbuseReport>d__6")]
		public sealed class _SubmitAbuseReport_d__6 : global::Il2CppSystem.Object
		{
			// Token: 0x0600510D RID: 20749 RVA: 0x0015B188 File Offset: 0x00159388
			// Note: this type is marked as 'beforefieldinit'.
			static _SubmitAbuseReport_d__6()
			{
				Il2CppClassPointerStore<AbuseReportController._SubmitAbuseReport_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbuseReportController>.NativeClassPtr, "<SubmitAbuseReport>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbuseReportController._SubmitAbuseReport_d__6>.NativeClassPtr);
				AbuseReportController._SubmitAbuseReport_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbuseReportController._SubmitAbuseReport_d__6>.NativeClassPtr, "<>1__state");
				AbuseReportController._SubmitAbuseReport_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbuseReportController._SubmitAbuseReport_d__6>.NativeClassPtr, "<>2__current");
				AbuseReportController._SubmitAbuseReport_d__6.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbuseReportController._SubmitAbuseReport_d__6>.NativeClassPtr, "message");
				AbuseReportController._SubmitAbuseReport_d__6.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbuseReportController._SubmitAbuseReport_d__6>.NativeClassPtr, "<uwr>5__2");
				AbuseReportController._SubmitAbuseReport_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbuseReportController._SubmitAbuseReport_d__6>.NativeClassPtr, 100674125);
				AbuseReportController._SubmitAbuseReport_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbuseReportController._SubmitAbuseReport_d__6>.NativeClassPtr, 100674127);
				AbuseReportController._SubmitAbuseReport_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbuseReportController._SubmitAbuseReport_d__6>.NativeClassPtr, 100674121);
				AbuseReportController._SubmitAbuseReport_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbuseReportController._SubmitAbuseReport_d__6>.NativeClassPtr, 100674122);
				AbuseReportController._SubmitAbuseReport_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbuseReportController._SubmitAbuseReport_d__6>.NativeClassPtr, 100674123);
				AbuseReportController._SubmitAbuseReport_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbuseReportController._SubmitAbuseReport_d__6>.NativeClassPtr, 100674124);
				AbuseReportController._SubmitAbuseReport_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbuseReportController._SubmitAbuseReport_d__6>.NativeClassPtr, 100674126);
			}

			// Token: 0x17001B55 RID: 6997
			// (get) Token: 0x0600510E RID: 20750 RVA: 0x0015B290 File Offset: 0x00159490
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbuseReportController._SubmitAbuseReport_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001B56 RID: 6998
			// (get) Token: 0x0600510F RID: 20751 RVA: 0x0015B2D0 File Offset: 0x001594D0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbuseReportController._SubmitAbuseReport_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005110 RID: 20752 RVA: 0x0015B310 File Offset: 0x00159510
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SubmitAbuseReport_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbuseReportController._SubmitAbuseReport_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbuseReportController._SubmitAbuseReport_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005111 RID: 20753 RVA: 0x0015B358 File Offset: 0x00159558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130509, XrefRangeEnd = 130514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbuseReportController._SubmitAbuseReport_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005112 RID: 20754 RVA: 0x0015B38C File Offset: 0x0015958C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130514, XrefRangeEnd = 130552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbuseReportController._SubmitAbuseReport_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005113 RID: 20755 RVA: 0x0015B3C8 File Offset: 0x001595C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130552, XrefRangeEnd = 130555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbuseReportController._SubmitAbuseReport_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005114 RID: 20756 RVA: 0x0015B3FC File Offset: 0x001595FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130555, XrefRangeEnd = 130560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbuseReportController._SubmitAbuseReport_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005115 RID: 20757 RVA: 0x0001F107 File Offset: 0x0001D307
			public _SubmitAbuseReport_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B51 RID: 6993
			// (get) Token: 0x06005116 RID: 20758 RVA: 0x0015B430 File Offset: 0x00159630
			// (set) Token: 0x06005117 RID: 20759 RVA: 0x0001F110 File Offset: 0x0001D310
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbuseReportController._SubmitAbuseReport_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbuseReportController._SubmitAbuseReport_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B52 RID: 6994
			// (get) Token: 0x06005118 RID: 20760 RVA: 0x0015B458 File Offset: 0x00159658
			// (set) Token: 0x06005119 RID: 20761 RVA: 0x0001F12B File Offset: 0x0001D32B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbuseReportController._SubmitAbuseReport_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbuseReportController._SubmitAbuseReport_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B53 RID: 6995
			// (get) Token: 0x0600511A RID: 20762 RVA: 0x0015B488 File Offset: 0x00159688
			// (set) Token: 0x0600511B RID: 20763 RVA: 0x0001F14A File Offset: 0x0001D34A
			public unsafe string message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbuseReportController._SubmitAbuseReport_d__6.NativeFieldInfoPtr_message);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbuseReportController._SubmitAbuseReport_d__6.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001B54 RID: 6996
			// (get) Token: 0x0600511C RID: 20764 RVA: 0x0015B4B0 File Offset: 0x001596B0
			// (set) Token: 0x0600511D RID: 20765 RVA: 0x0001F169 File Offset: 0x0001D369
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbuseReportController._SubmitAbuseReport_d__6.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbuseReportController._SubmitAbuseReport_d__6.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E53 RID: 15955
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003E54 RID: 15956
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003E55 RID: 15957
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04003E56 RID: 15958
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003E57 RID: 15959
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003E58 RID: 15960
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003E59 RID: 15961
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003E5A RID: 15962
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003E5B RID: 15963
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003E5C RID: 15964
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003E5D RID: 15965
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
