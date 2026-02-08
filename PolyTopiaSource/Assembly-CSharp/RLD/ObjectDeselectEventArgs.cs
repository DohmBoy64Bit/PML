using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000228 RID: 552
	public class ObjectDeselectEventArgs : Object
	{
		// Token: 0x06002AFA RID: 11002 RVA: 0x000CB23C File Offset: 0x000C943C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectDeselectEventArgs()
		{
			Il2CppClassPointerStore<ObjectDeselectEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectDeselectEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectDeselectEventArgs>.NativeClassPtr);
			ObjectDeselectEventArgs.NativeFieldInfoPtr__deselectReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDeselectEventArgs>.NativeClassPtr, "_deselectReason");
			ObjectDeselectEventArgs.NativeMethodInfoPtr_get_DeselectReason_Public_get_ObjectDeselectReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDeselectEventArgs>.NativeClassPtr, 100669833);
			ObjectDeselectEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ObjectDeselectReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDeselectEventArgs>.NativeClassPtr, 100669834);
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06002AFB RID: 11003 RVA: 0x000CB2A8 File Offset: 0x000C94A8
		public unsafe ObjectDeselectReason DeselectReason
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectDeselectEventArgs.NativeMethodInfoPtr_get_DeselectReason_Public_get_ObjectDeselectReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectDeselectReason>(intPtr3) : null;
			}
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x000CB2E8 File Offset: 0x000C94E8
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectDeselectEventArgs(ObjectDeselectReason deselectReason)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectDeselectEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deselectReason);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectDeselectEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ObjectDeselectReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x00010FDF File Offset: 0x0000F1DF
		public ObjectDeselectEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06002AFE RID: 11006 RVA: 0x000CB334 File Offset: 0x000C9534
		// (set) Token: 0x06002AFF RID: 11007 RVA: 0x00010FE8 File Offset: 0x0000F1E8
		public unsafe ObjectDeselectReason _deselectReason
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectDeselectEventArgs.NativeFieldInfoPtr__deselectReason);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectDeselectReason>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectDeselectEventArgs.NativeFieldInfoPtr__deselectReason), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400214A RID: 8522
		private static readonly IntPtr NativeFieldInfoPtr__deselectReason;

		// Token: 0x0400214B RID: 8523
		private static readonly IntPtr NativeMethodInfoPtr_get_DeselectReason_Public_get_ObjectDeselectReason_0;

		// Token: 0x0400214C RID: 8524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectDeselectReason_0;
	}
}
