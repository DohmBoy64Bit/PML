using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000214 RID: 532
	public class IRTObjectSelectionListener : Object
	{
		// Token: 0x060029E8 RID: 10728 RVA: 0x000C74A0 File Offset: 0x000C56A0
		// Note: this type is marked as 'beforefieldinit'.
		static IRTObjectSelectionListener()
		{
			Il2CppClassPointerStore<IRTObjectSelectionListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "IRTObjectSelectionListener");
			IRTObjectSelectionListener.NativeMethodInfoPtr_OnCanBeSelected_Public_Abstract_Virtual_New_Boolean_ObjectSelectEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRTObjectSelectionListener>.NativeClassPtr, 100669700);
			IRTObjectSelectionListener.NativeMethodInfoPtr_OnSelected_Public_Abstract_Virtual_New_Void_ObjectSelectEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRTObjectSelectionListener>.NativeClassPtr, 100669701);
			IRTObjectSelectionListener.NativeMethodInfoPtr_OnDeselected_Public_Abstract_Virtual_New_Void_ObjectDeselectEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRTObjectSelectionListener>.NativeClassPtr, 100669702);
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x000C7504 File Offset: 0x000C5704
		[CallerCount(0)]
		public unsafe virtual bool OnCanBeSelected(ObjectSelectEventArgs selectArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectArgs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRTObjectSelectionListener.NativeMethodInfoPtr_OnCanBeSelected_Public_Abstract_Virtual_New_Boolean_ObjectSelectEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x000C755C File Offset: 0x000C575C
		[CallerCount(0)]
		public unsafe virtual void OnSelected(ObjectSelectEventArgs selectArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectArgs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRTObjectSelectionListener.NativeMethodInfoPtr_OnSelected_Public_Abstract_Virtual_New_Void_ObjectSelectEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x000C75AC File Offset: 0x000C57AC
		[CallerCount(0)]
		public unsafe virtual void OnDeselected(ObjectDeselectEventArgs deselectArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deselectArgs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRTObjectSelectionListener.NativeMethodInfoPtr_OnDeselected_Public_Abstract_Virtual_New_Void_ObjectDeselectEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x000108A5 File Offset: 0x0000EAA5
		public IRTObjectSelectionListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400206D RID: 8301
		private static readonly IntPtr NativeMethodInfoPtr_OnCanBeSelected_Public_Abstract_Virtual_New_Boolean_ObjectSelectEventArgs_0;

		// Token: 0x0400206E RID: 8302
		private static readonly IntPtr NativeMethodInfoPtr_OnSelected_Public_Abstract_Virtual_New_Void_ObjectSelectEventArgs_0;

		// Token: 0x0400206F RID: 8303
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselected_Public_Abstract_Virtual_New_Void_ObjectDeselectEventArgs_0;
	}
}
