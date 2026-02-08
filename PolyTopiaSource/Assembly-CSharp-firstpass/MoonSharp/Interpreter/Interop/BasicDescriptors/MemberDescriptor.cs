using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
	// Token: 0x020000D6 RID: 214
	public static class MemberDescriptor : Object
	{
		// Token: 0x060010A6 RID: 4262 RVA: 0x00059318 File Offset: 0x00057518
		// Note: this type is marked as 'beforefieldinit'.
		static MemberDescriptor()
		{
			Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.BasicDescriptors", "MemberDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr);
			MemberDescriptor.NativeMethodInfoPtr_HasAllFlags_Public_Static_Boolean_MemberDescriptorAccess_MemberDescriptorAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666272);
			MemberDescriptor.NativeMethodInfoPtr_CanRead_Public_Static_Boolean_IMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666273);
			MemberDescriptor.NativeMethodInfoPtr_CanWrite_Public_Static_Boolean_IMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666274);
			MemberDescriptor.NativeMethodInfoPtr_CanExecute_Public_Static_Boolean_IMemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666275);
			MemberDescriptor.NativeMethodInfoPtr_GetGetterCallbackAsDynValue_Public_Static_DynValue_IMemberDescriptor_Script_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666276);
			MemberDescriptor.NativeMethodInfoPtr_WithAccessOrNull_Public_Static_IMemberDescriptor_IMemberDescriptor_MemberDescriptorAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666277);
			MemberDescriptor.NativeMethodInfoPtr_CheckAccess_Public_Static_Void_IMemberDescriptor_MemberDescriptorAccess_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, 100666278);
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x000593D4 File Offset: 0x000575D4
		[CallerCount(0)]
		public unsafe static bool HasAllFlags(this MemberDescriptorAccess access, MemberDescriptorAccess flag)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(access);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberDescriptor.NativeMethodInfoPtr_HasAllFlags_Public_Static_Boolean_MemberDescriptorAccess_MemberDescriptorAccess_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00059428 File Offset: 0x00057628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42661, XrefRangeEnd = 42664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanRead(this IMemberDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberDescriptor.NativeMethodInfoPtr_CanRead_Public_Static_Boolean_IMemberDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0005946C File Offset: 0x0005766C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42664, XrefRangeEnd = 42667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanWrite(this IMemberDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberDescriptor.NativeMethodInfoPtr_CanWrite_Public_Static_Boolean_IMemberDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x000594B0 File Offset: 0x000576B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42667, XrefRangeEnd = 42670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanExecute(this IMemberDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberDescriptor.NativeMethodInfoPtr_CanExecute_Public_Static_Boolean_IMemberDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x000594F4 File Offset: 0x000576F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42688, RefRangeEnd = 42689, XrefRangeStart = 42670, XrefRangeEnd = 42688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue GetGetterCallbackAsDynValue(this IMemberDescriptor desc, Script script, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(script);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberDescriptor.NativeMethodInfoPtr_GetGetterCallbackAsDynValue_Public_Static_DynValue_IMemberDescriptor_Script_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0005955C File Offset: 0x0005775C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42689, XrefRangeEnd = 42692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMemberDescriptor WithAccessOrNull(this IMemberDescriptor desc, MemberDescriptorAccess access)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(access);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberDescriptor.NativeMethodInfoPtr_WithAccessOrNull_Public_Static_IMemberDescriptor_IMemberDescriptor_MemberDescriptorAccess_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMemberDescriptor>(intPtr3) : null;
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x000595B4 File Offset: 0x000577B4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 42704, RefRangeEnd = 42721, XrefRangeStart = 42692, XrefRangeEnd = 42704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckAccess(this IMemberDescriptor desc, MemberDescriptorAccess access, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(access);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberDescriptor.NativeMethodInfoPtr_CheckAccess_Public_Static_Void_IMemberDescriptor_MemberDescriptorAccess_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00006EF0 File Offset: 0x000050F0
		public MemberDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeMethodInfoPtr_HasAllFlags_Public_Static_Boolean_MemberDescriptorAccess_MemberDescriptorAccess_0;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeMethodInfoPtr_CanRead_Public_Static_Boolean_IMemberDescriptor_0;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeMethodInfoPtr_CanWrite_Public_Static_Boolean_IMemberDescriptor_0;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeMethodInfoPtr_CanExecute_Public_Static_Boolean_IMemberDescriptor_0;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeMethodInfoPtr_GetGetterCallbackAsDynValue_Public_Static_DynValue_IMemberDescriptor_Script_Object_0;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeMethodInfoPtr_WithAccessOrNull_Public_Static_IMemberDescriptor_IMemberDescriptor_MemberDescriptorAccess_0;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeMethodInfoPtr_CheckAccess_Public_Static_Void_IMemberDescriptor_MemberDescriptorAccess_Object_0;

		// Token: 0x020001DD RID: 477
		[ObfuscatedName("MoonSharp.Interpreter.Interop.BasicDescriptors.MemberDescriptor+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06001CD0 RID: 7376 RVA: 0x0008AC50 File Offset: 0x00088E50
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<MemberDescriptor.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MemberDescriptor>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberDescriptor.__c__DisplayClass4_0>.NativeClassPtr);
				MemberDescriptor.__c__DisplayClass4_0.NativeFieldInfoPtr_desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberDescriptor.__c__DisplayClass4_0>.NativeClassPtr, "desc");
				MemberDescriptor.__c__DisplayClass4_0.NativeFieldInfoPtr_script = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberDescriptor.__c__DisplayClass4_0>.NativeClassPtr, "script");
				MemberDescriptor.__c__DisplayClass4_0.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberDescriptor.__c__DisplayClass4_0>.NativeClassPtr, "obj");
				MemberDescriptor.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor.__c__DisplayClass4_0>.NativeClassPtr, 100666279);
				MemberDescriptor.__c__DisplayClass4_0.NativeMethodInfoPtr__GetGetterCallbackAsDynValue_b__0_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberDescriptor.__c__DisplayClass4_0>.NativeClassPtr, 100666280);
			}

			// Token: 0x06001CD1 RID: 7377 RVA: 0x0008ACE0 File Offset: 0x00088EE0
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberDescriptor.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberDescriptor.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CD2 RID: 7378 RVA: 0x0008AD1C File Offset: 0x00088F1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42658, XrefRangeEnd = 42661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynValue _GetGetterCallbackAsDynValue_b__0(ScriptExecutionContext p1, CallbackArguments p2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberDescriptor.__c__DisplayClass4_0.NativeMethodInfoPtr__GetGetterCallbackAsDynValue_b__0_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}

			// Token: 0x06001CD3 RID: 7379 RVA: 0x0000B5CC File Offset: 0x000097CC
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000695 RID: 1685
			// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x0008AD80 File Offset: 0x00088F80
			// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x0000B5D5 File Offset: 0x000097D5
			public unsafe IMemberDescriptor desc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.__c__DisplayClass4_0.NativeFieldInfoPtr_desc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMemberDescriptor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.__c__DisplayClass4_0.NativeFieldInfoPtr_desc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000696 RID: 1686
			// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x0008ADB0 File Offset: 0x00088FB0
			// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x0000B5F4 File Offset: 0x000097F4
			public unsafe Script script
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.__c__DisplayClass4_0.NativeFieldInfoPtr_script);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Script>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.__c__DisplayClass4_0.NativeFieldInfoPtr_script), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000697 RID: 1687
			// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x0008ADE0 File Offset: 0x00088FE0
			// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x0000B613 File Offset: 0x00009813
			public unsafe Object obj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.__c__DisplayClass4_0.NativeFieldInfoPtr_obj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberDescriptor.__c__DisplayClass4_0.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400170D RID: 5901
			private static readonly IntPtr NativeFieldInfoPtr_desc;

			// Token: 0x0400170E RID: 5902
			private static readonly IntPtr NativeFieldInfoPtr_script;

			// Token: 0x0400170F RID: 5903
			private static readonly IntPtr NativeFieldInfoPtr_obj;

			// Token: 0x04001710 RID: 5904
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001711 RID: 5905
			private static readonly IntPtr NativeMethodInfoPtr__GetGetterCallbackAsDynValue_b__0_Internal_DynValue_ScriptExecutionContext_CallbackArguments_0;
		}
	}
}
