using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Polytoria.Lua;

namespace Polytoria.Datamodel
{
	// Token: 0x020002AA RID: 682
	public class Signal : Instance
	{
		// Token: 0x06003A20 RID: 14880 RVA: 0x00107050 File Offset: 0x00105250
		// Note: this type is marked as 'beforefieldinit'.
		static Signal()
		{
			Il2CppClassPointerStore<Signal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "Signal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Signal>.NativeClassPtr);
			Signal.NativeFieldInfoPtr_Invoked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Signal>.NativeClassPtr, "Invoked");
			Signal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Signal>.NativeClassPtr, 100672201);
			Signal.NativeMethodInfoPtr_Invoke_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Signal>.NativeClassPtr, 100672200);
			Signal.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Signal>.NativeClassPtr, 100672202);
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x001070D0 File Offset: 0x001052D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117836, XrefRangeEnd = 117845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Signal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Signal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Signal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A22 RID: 14882 RVA: 0x0010710C File Offset: 0x0010530C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117846, RefRangeEnd = 117847, XrefRangeStart = 117845, XrefRangeEnd = 117846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke([Optional] Il2CppReferenceArray<Object> par)
		{
			if (par == null)
			{
				par = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(par);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Signal.NativeMethodInfoPtr_Invoke_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A23 RID: 14883 RVA: 0x0010715C File Offset: 0x0010535C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Signal.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x00016802 File Offset: 0x00014A02
		public Signal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x06003A25 RID: 14885 RVA: 0x001071A4 File Offset: 0x001053A4
		// (set) Token: 0x06003A26 RID: 14886 RVA: 0x0001680B File Offset: 0x00014A0B
		public unsafe LuaEvent Invoked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Signal.NativeFieldInfoPtr_Invoked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Signal.NativeFieldInfoPtr_Invoked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002D17 RID: 11543
		private static readonly IntPtr NativeFieldInfoPtr_Invoked;

		// Token: 0x04002D18 RID: 11544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D19 RID: 11545
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002D1A RID: 11546
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;
	}
}
