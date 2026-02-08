using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002CF RID: 719
	public class BaseScriptProxy : InstanceProxy
	{
		// Token: 0x06003F84 RID: 16260 RVA: 0x0011D1A0 File Offset: 0x0011B3A0
		// Note: this type is marked as 'beforefieldinit'.
		static BaseScriptProxy()
		{
			Il2CppClassPointerStore<BaseScriptProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "BaseScriptProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseScriptProxy>.NativeClassPtr);
			BaseScriptProxy.NativeFieldInfoPtr_baseScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseScriptProxy>.NativeClassPtr, "baseScript");
			BaseScriptProxy.NativeMethodInfoPtr_get_Item_Public_get_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptProxy>.NativeClassPtr, 100673214);
			BaseScriptProxy.NativeMethodInfoPtr_set_Item_Public_set_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptProxy>.NativeClassPtr, 100673215);
			BaseScriptProxy.NativeMethodInfoPtr__ctor_Public_Void_BaseScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptProxy>.NativeClassPtr, 100673213);
			BaseScriptProxy.NativeMethodInfoPtr_Call_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseScriptProxy>.NativeClassPtr, 100673216);
		}

		// Token: 0x170015CB RID: 5579
		public unsafe Object this[string name]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128454, XrefRangeEnd = 128456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseScriptProxy.NativeMethodInfoPtr_get_Item_Public_get_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128456, XrefRangeEnd = 128458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseScriptProxy.NativeMethodInfoPtr_set_Item_Public_set_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x0011D2D8 File Offset: 0x0011B4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseScriptProxy(BaseScript target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseScriptProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseScriptProxy.NativeMethodInfoPtr__ctor_Public_Void_BaseScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x0011D324 File Offset: 0x0011B524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128458, XrefRangeEnd = 128460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Call(string function, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseScriptProxy.NativeMethodInfoPtr_Call_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x0001848A File Offset: 0x0001668A
		public void Call(string function, params Object[] args)
		{
			this.Call(function, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x00018499 File Offset: 0x00016699
		public BaseScriptProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x06003F8B RID: 16267 RVA: 0x0011D388 File Offset: 0x0011B588
		// (set) Token: 0x06003F8C RID: 16268 RVA: 0x000184A2 File Offset: 0x000166A2
		public unsafe BaseScript baseScript
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseScriptProxy.NativeFieldInfoPtr_baseScript);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseScript>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseScriptProxy.NativeFieldInfoPtr_baseScript), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003157 RID: 12631
		private static readonly IntPtr NativeFieldInfoPtr_baseScript;

		// Token: 0x04003158 RID: 12632
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_String_0;

		// Token: 0x04003159 RID: 12633
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_String_Object_0;

		// Token: 0x0400315A RID: 12634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BaseScript_0;

		// Token: 0x0400315B RID: 12635
		private static readonly IntPtr NativeMethodInfoPtr_Call_Public_Void_String_Il2CppReferenceArray_1_Object_0;
	}
}
