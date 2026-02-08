using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Polytoria.Lua;

namespace Polytoria.Datamodel
{
	// Token: 0x020002BF RID: 703
	public class ValueBase : Instance
	{
		// Token: 0x06003E24 RID: 15908 RVA: 0x0011793C File Offset: 0x00115B3C
		// Note: this type is marked as 'beforefieldinit'.
		static ValueBase()
		{
			Il2CppClassPointerStore<ValueBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "ValueBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueBase>.NativeClassPtr);
			ValueBase.NativeFieldInfoPtr_Changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueBase>.NativeClassPtr, "Changed");
			ValueBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueBase>.NativeClassPtr, 100672855);
			ValueBase.NativeMethodInfoPtr_InvokeChanged_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueBase>.NativeClassPtr, 100672854);
			ValueBase.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueBase>.NativeClassPtr, 100672856);
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x001179BC File Offset: 0x00115BBC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 123449, RefRangeEnd = 123455, XrefRangeStart = 123440, XrefRangeEnd = 123449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x001179F8 File Offset: 0x00115BF8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 123460, RefRangeEnd = 123472, XrefRangeStart = 123455, XrefRangeEnd = 123460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueBase.NativeMethodInfoPtr_InvokeChanged_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x00117A2C File Offset: 0x00115C2C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValueBase.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x00017D49 File Offset: 0x00015F49
		public ValueBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x06003E29 RID: 15913 RVA: 0x00117A74 File Offset: 0x00115C74
		// (set) Token: 0x06003E2A RID: 15914 RVA: 0x00017D52 File Offset: 0x00015F52
		public unsafe LuaEvent Changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueBase.NativeFieldInfoPtr_Changed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueBase.NativeFieldInfoPtr_Changed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400305B RID: 12379
		private static readonly IntPtr NativeFieldInfoPtr_Changed;

		// Token: 0x0400305C RID: 12380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400305D RID: 12381
		private static readonly IntPtr NativeMethodInfoPtr_InvokeChanged_Protected_Void_0;

		// Token: 0x0400305E RID: 12382
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;
	}
}
