using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x02000307 RID: 775
	public class ValueBaseProxy : InstanceProxy
	{
		// Token: 0x0600434A RID: 17226 RVA: 0x0012E384 File Offset: 0x0012C584
		// Note: this type is marked as 'beforefieldinit'.
		static ValueBaseProxy()
		{
			Il2CppClassPointerStore<ValueBaseProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "ValueBaseProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueBaseProxy>.NativeClassPtr);
			ValueBaseProxy.NativeFieldInfoPtr_valueBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueBaseProxy>.NativeClassPtr, "valueBase");
			ValueBaseProxy.NativeMethodInfoPtr_get_Changed_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueBaseProxy>.NativeClassPtr, 100673955);
			ValueBaseProxy.NativeMethodInfoPtr__ctor_Public_Void_ValueBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueBaseProxy>.NativeClassPtr, 100673954);
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x0600434B RID: 17227 RVA: 0x0012E3F0 File Offset: 0x0012C5F0
		public unsafe LuaEvent Changed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueBaseProxy.NativeMethodInfoPtr_get_Changed_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x0012E430 File Offset: 0x0012C630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueBaseProxy(ValueBase target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueBaseProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueBaseProxy.NativeMethodInfoPtr__ctor_Public_Void_ValueBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x00018D59 File Offset: 0x00016F59
		public ValueBaseProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x0600434E RID: 17230 RVA: 0x0012E47C File Offset: 0x0012C67C
		// (set) Token: 0x0600434F RID: 17231 RVA: 0x00018D62 File Offset: 0x00016F62
		public unsafe ValueBase valueBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueBaseProxy.NativeFieldInfoPtr_valueBase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueBaseProxy.NativeFieldInfoPtr_valueBase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003474 RID: 13428
		private static readonly IntPtr NativeFieldInfoPtr_valueBase;

		// Token: 0x04003475 RID: 13429
		private static readonly IntPtr NativeMethodInfoPtr_get_Changed_Public_get_LuaEvent_0;

		// Token: 0x04003476 RID: 13430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ValueBase_0;
	}
}
