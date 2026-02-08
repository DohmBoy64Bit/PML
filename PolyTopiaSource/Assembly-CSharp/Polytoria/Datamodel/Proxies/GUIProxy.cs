using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002DB RID: 731
	public class GUIProxy : InstanceProxy
	{
		// Token: 0x06004058 RID: 16472 RVA: 0x00120F4C File Offset: 0x0011F14C
		// Note: this type is marked as 'beforefieldinit'.
		static GUIProxy()
		{
			Il2CppClassPointerStore<GUIProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "GUIProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIProxy>.NativeClassPtr);
			GUIProxy.NativeFieldInfoPtr_gui = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIProxy>.NativeClassPtr, "gui");
			GUIProxy.NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIProxy>.NativeClassPtr, 100673377);
			GUIProxy.NativeMethodInfoPtr_set_Visible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIProxy>.NativeClassPtr, 100673378);
			GUIProxy.NativeMethodInfoPtr__ctor_Public_Void_GUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIProxy>.NativeClassPtr, 100673376);
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x06004059 RID: 16473 RVA: 0x00120FCC File Offset: 0x0011F1CC
		// (set) Token: 0x0600405A RID: 16474 RVA: 0x00121008 File Offset: 0x0011F208
		public unsafe bool Visible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIProxy.NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128577, XrefRangeEnd = 128579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIProxy.NativeMethodInfoPtr_set_Visible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x00121048 File Offset: 0x0011F248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIProxy(GUI target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIProxy.NativeMethodInfoPtr__ctor_Public_Void_GUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x00018679 File Offset: 0x00016879
		public GUIProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x0600405D RID: 16477 RVA: 0x00121094 File Offset: 0x0011F294
		// (set) Token: 0x0600405E RID: 16478 RVA: 0x00018682 File Offset: 0x00016882
		public unsafe GUI gui
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIProxy.NativeFieldInfoPtr_gui);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIProxy.NativeFieldInfoPtr_gui), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003206 RID: 12806
		private static readonly IntPtr NativeFieldInfoPtr_gui;

		// Token: 0x04003207 RID: 12807
		private static readonly IntPtr NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0;

		// Token: 0x04003208 RID: 12808
		private static readonly IntPtr NativeMethodInfoPtr_set_Visible_Public_set_Void_Boolean_0;

		// Token: 0x04003209 RID: 12809
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GUI_0;
	}
}
