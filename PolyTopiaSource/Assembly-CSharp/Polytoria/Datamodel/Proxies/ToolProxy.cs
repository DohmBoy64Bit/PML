using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002FC RID: 764
	public class ToolProxy : DynamicInstanceProxy
	{
		// Token: 0x0600429D RID: 17053 RVA: 0x0012B3F4 File Offset: 0x001295F4
		// Note: this type is marked as 'beforefieldinit'.
		static ToolProxy()
		{
			Il2CppClassPointerStore<ToolProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "ToolProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToolProxy>.NativeClassPtr);
			ToolProxy.NativeFieldInfoPtr_tool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolProxy>.NativeClassPtr, "tool");
			ToolProxy.NativeMethodInfoPtr_get_Activated_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolProxy>.NativeClassPtr, 100673826);
			ToolProxy.NativeMethodInfoPtr_get_Deactivated_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolProxy>.NativeClassPtr, 100673827);
			ToolProxy.NativeMethodInfoPtr_get_Equipped_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolProxy>.NativeClassPtr, 100673828);
			ToolProxy.NativeMethodInfoPtr_get_Unequipped_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolProxy>.NativeClassPtr, 100673829);
			ToolProxy.NativeMethodInfoPtr_get_Droppable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolProxy>.NativeClassPtr, 100673831);
			ToolProxy.NativeMethodInfoPtr_set_Droppable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolProxy>.NativeClassPtr, 100673832);
			ToolProxy.NativeMethodInfoPtr__ctor_Public_Void_Tool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolProxy>.NativeClassPtr, 100673825);
			ToolProxy.NativeMethodInfoPtr_Play_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolProxy>.NativeClassPtr, 100673830);
		}

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x0600429E RID: 17054 RVA: 0x0012B4D8 File Offset: 0x001296D8
		public unsafe LuaEvent Activated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolProxy.NativeMethodInfoPtr_get_Activated_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x0600429F RID: 17055 RVA: 0x0012B518 File Offset: 0x00129718
		public unsafe LuaEvent Deactivated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolProxy.NativeMethodInfoPtr_get_Deactivated_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x060042A0 RID: 17056 RVA: 0x0012B558 File Offset: 0x00129758
		public unsafe LuaEvent Equipped
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolProxy.NativeMethodInfoPtr_get_Equipped_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x060042A1 RID: 17057 RVA: 0x0012B598 File Offset: 0x00129798
		public unsafe LuaEvent Unequipped
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolProxy.NativeMethodInfoPtr_get_Unequipped_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x060042A2 RID: 17058 RVA: 0x0012B5D8 File Offset: 0x001297D8
		// (set) Token: 0x060042A3 RID: 17059 RVA: 0x0012B614 File Offset: 0x00129814
		public unsafe bool Droppable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolProxy.NativeMethodInfoPtr_get_Droppable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129064, XrefRangeEnd = 129066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolProxy.NativeMethodInfoPtr_set_Droppable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060042A4 RID: 17060 RVA: 0x0012B654 File Offset: 0x00129854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToolProxy(Tool target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToolProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolProxy.NativeMethodInfoPtr__ctor_Public_Void_Tool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042A5 RID: 17061 RVA: 0x0012B6A0 File Offset: 0x001298A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129066, XrefRangeEnd = 129068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(string anim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(anim);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolProxy.NativeMethodInfoPtr_Play_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042A6 RID: 17062 RVA: 0x00018BA1 File Offset: 0x00016DA1
		public ToolProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x060042A7 RID: 17063 RVA: 0x0012B6E4 File Offset: 0x001298E4
		// (set) Token: 0x060042A8 RID: 17064 RVA: 0x00018BAA File Offset: 0x00016DAA
		public unsafe Tool tool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolProxy.NativeFieldInfoPtr_tool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolProxy.NativeFieldInfoPtr_tool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033E8 RID: 13288
		private static readonly IntPtr NativeFieldInfoPtr_tool;

		// Token: 0x040033E9 RID: 13289
		private static readonly IntPtr NativeMethodInfoPtr_get_Activated_Public_get_LuaEvent_0;

		// Token: 0x040033EA RID: 13290
		private static readonly IntPtr NativeMethodInfoPtr_get_Deactivated_Public_get_LuaEvent_0;

		// Token: 0x040033EB RID: 13291
		private static readonly IntPtr NativeMethodInfoPtr_get_Equipped_Public_get_LuaEvent_0;

		// Token: 0x040033EC RID: 13292
		private static readonly IntPtr NativeMethodInfoPtr_get_Unequipped_Public_get_LuaEvent_0;

		// Token: 0x040033ED RID: 13293
		private static readonly IntPtr NativeMethodInfoPtr_get_Droppable_Public_get_Boolean_0;

		// Token: 0x040033EE RID: 13294
		private static readonly IntPtr NativeMethodInfoPtr_set_Droppable_Public_set_Void_Boolean_0;

		// Token: 0x040033EF RID: 13295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Tool_0;

		// Token: 0x040033F0 RID: 13296
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_String_0;
	}
}
