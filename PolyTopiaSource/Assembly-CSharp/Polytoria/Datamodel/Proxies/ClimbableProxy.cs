using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002D3 RID: 723
	public class ClimbableProxy : PartProxy
	{
		// Token: 0x06003FCD RID: 16333 RVA: 0x0011E60C File Offset: 0x0011C80C
		// Note: this type is marked as 'beforefieldinit'.
		static ClimbableProxy()
		{
			Il2CppClassPointerStore<ClimbableProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "ClimbableProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClimbableProxy>.NativeClassPtr);
			ClimbableProxy.NativeFieldInfoPtr_climbable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbableProxy>.NativeClassPtr, "climbable");
			ClimbableProxy.NativeMethodInfoPtr_get_ClimbSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClimbableProxy>.NativeClassPtr, 100673270);
			ClimbableProxy.NativeMethodInfoPtr_set_ClimbSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClimbableProxy>.NativeClassPtr, 100673271);
			ClimbableProxy.NativeMethodInfoPtr__ctor_Public_Void_Climbable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClimbableProxy>.NativeClassPtr, 100673269);
		}

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x06003FCE RID: 16334 RVA: 0x0011E68C File Offset: 0x0011C88C
		// (set) Token: 0x06003FCF RID: 16335 RVA: 0x0011E6C8 File Offset: 0x0011C8C8
		public unsafe float ClimbSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClimbableProxy.NativeMethodInfoPtr_get_ClimbSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128485, XrefRangeEnd = 128487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClimbableProxy.NativeMethodInfoPtr_set_ClimbSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x0011E708 File Offset: 0x0011C908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128487, XrefRangeEnd = 128492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClimbableProxy(Climbable target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClimbableProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClimbableProxy.NativeMethodInfoPtr__ctor_Public_Void_Climbable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x00018539 File Offset: 0x00016739
		public ClimbableProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x06003FD2 RID: 16338 RVA: 0x0011E754 File Offset: 0x0011C954
		// (set) Token: 0x06003FD3 RID: 16339 RVA: 0x00018542 File Offset: 0x00016742
		public unsafe Climbable climbable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClimbableProxy.NativeFieldInfoPtr_climbable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Climbable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClimbableProxy.NativeFieldInfoPtr_climbable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003193 RID: 12691
		private static readonly IntPtr NativeFieldInfoPtr_climbable;

		// Token: 0x04003194 RID: 12692
		private static readonly IntPtr NativeMethodInfoPtr_get_ClimbSpeed_Public_get_Single_0;

		// Token: 0x04003195 RID: 12693
		private static readonly IntPtr NativeMethodInfoPtr_set_ClimbSpeed_Public_set_Void_Single_0;

		// Token: 0x04003196 RID: 12694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Climbable_0;
	}
}
