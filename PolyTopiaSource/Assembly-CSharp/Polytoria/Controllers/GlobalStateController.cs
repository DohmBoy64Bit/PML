using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x02000328 RID: 808
	public class GlobalStateController : MonoBehaviour
	{
		// Token: 0x06004576 RID: 17782 RVA: 0x00136CB0 File Offset: 0x00134EB0
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalStateController()
		{
			Il2CppClassPointerStore<GlobalStateController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "GlobalStateController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalStateController>.NativeClassPtr);
			GlobalStateController.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalStateController>.NativeClassPtr, "instance");
			GlobalStateController.NativeFieldInfoPtr_ScrollViewSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalStateController>.NativeClassPtr, "ScrollViewSpeed");
			GlobalStateController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalStateController>.NativeClassPtr, 100674326);
			GlobalStateController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalStateController>.NativeClassPtr, 100674324);
			GlobalStateController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalStateController>.NativeClassPtr, 100674325);
		}

		// Token: 0x06004577 RID: 17783 RVA: 0x00136D44 File Offset: 0x00134F44
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GlobalStateController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalStateController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalStateController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x00136D80 File Offset: 0x00134F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134359, XrefRangeEnd = 134363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalStateController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x00136DB4 File Offset: 0x00134FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134363, XrefRangeEnd = 134370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalStateController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600457A RID: 17786 RVA: 0x00019998 File Offset: 0x00017B98
		public GlobalStateController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x0600457B RID: 17787 RVA: 0x00136DE8 File Offset: 0x00134FE8
		// (set) Token: 0x0600457C RID: 17788 RVA: 0x000199A1 File Offset: 0x00017BA1
		public unsafe static GlobalStateController instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GlobalStateController.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalStateController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalStateController.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x0600457D RID: 17789 RVA: 0x00136E10 File Offset: 0x00135010
		// (set) Token: 0x0600457E RID: 17790 RVA: 0x000199B3 File Offset: 0x00017BB3
		public unsafe static float ScrollViewSpeed
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(GlobalStateController.NativeFieldInfoPtr_ScrollViewSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalStateController.NativeFieldInfoPtr_ScrollViewSpeed, (void*)(&value));
			}
		}

		// Token: 0x040035FD RID: 13821
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x040035FE RID: 13822
		private static readonly IntPtr NativeFieldInfoPtr_ScrollViewSpeed;

		// Token: 0x040035FF RID: 13823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003600 RID: 13824
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003601 RID: 13825
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
	}
}
