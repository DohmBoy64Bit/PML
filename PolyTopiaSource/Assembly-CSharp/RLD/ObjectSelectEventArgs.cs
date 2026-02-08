using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000227 RID: 551
	public class ObjectSelectEventArgs : Object
	{
		// Token: 0x06002AF4 RID: 10996 RVA: 0x000CB114 File Offset: 0x000C9314
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelectEventArgs()
		{
			Il2CppClassPointerStore<ObjectSelectEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectSelectEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSelectEventArgs>.NativeClassPtr);
			ObjectSelectEventArgs.NativeFieldInfoPtr__selectReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelectEventArgs>.NativeClassPtr, "_selectReason");
			ObjectSelectEventArgs.NativeMethodInfoPtr_get_SelectReason_Public_get_ObjectSelectReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectEventArgs>.NativeClassPtr, 100669831);
			ObjectSelectEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ObjectSelectReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelectEventArgs>.NativeClassPtr, 100669832);
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x000CB180 File Offset: 0x000C9380
		public unsafe ObjectSelectReason SelectReason
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectEventArgs.NativeMethodInfoPtr_get_SelectReason_Public_get_ObjectSelectReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSelectReason>(intPtr3) : null;
			}
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x000CB1C0 File Offset: 0x000C93C0
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectEventArgs(ObjectSelectReason selectReason)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelectEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectReason);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelectEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ObjectSelectReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x00010FB7 File Offset: 0x0000F1B7
		public ObjectSelectEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06002AF8 RID: 11000 RVA: 0x000CB20C File Offset: 0x000C940C
		// (set) Token: 0x06002AF9 RID: 11001 RVA: 0x00010FC0 File Offset: 0x0000F1C0
		public unsafe ObjectSelectReason _selectReason
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectEventArgs.NativeFieldInfoPtr__selectReason);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectReason>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelectEventArgs.NativeFieldInfoPtr__selectReason), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002147 RID: 8519
		private static readonly IntPtr NativeFieldInfoPtr__selectReason;

		// Token: 0x04002148 RID: 8520
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectReason_Public_get_ObjectSelectReason_0;

		// Token: 0x04002149 RID: 8521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectSelectReason_0;
	}
}
