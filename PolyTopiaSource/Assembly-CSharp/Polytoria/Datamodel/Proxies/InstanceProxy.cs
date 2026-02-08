using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002DE RID: 734
	public class InstanceProxy : global::Il2CppSystem.Object
	{
		// Token: 0x06004075 RID: 16501 RVA: 0x00121644 File Offset: 0x0011F844
		// Note: this type is marked as 'beforefieldinit'.
		static InstanceProxy()
		{
			Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "InstanceProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr);
			InstanceProxy.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, "target");
			InstanceProxy.NativeMethodInfoPtr_get_Item_Public_get_Instance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673394);
			InstanceProxy.NativeMethodInfoPtr_get_Item_Public_get_Instance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673395);
			InstanceProxy.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673396);
			InstanceProxy.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673397);
			InstanceProxy.NativeMethodInfoPtr_get_ClassName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673398);
			InstanceProxy.NativeMethodInfoPtr_get_Shared_Public_get_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673399);
			InstanceProxy.NativeMethodInfoPtr_get_ClientSpawned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673400);
			InstanceProxy.NativeMethodInfoPtr_get_Parent_Public_get_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673401);
			InstanceProxy.NativeMethodInfoPtr_set_Parent_Public_set_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673402);
			InstanceProxy.NativeMethodInfoPtr_get_ChildRemoved_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673403);
			InstanceProxy.NativeMethodInfoPtr_get_ChildAdded_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673404);
			InstanceProxy.NativeMethodInfoPtr_get_Touched_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673405);
			InstanceProxy.NativeMethodInfoPtr_get_TouchEnded_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673406);
			InstanceProxy.NativeMethodInfoPtr_get_Clicked_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673407);
			InstanceProxy.NativeMethodInfoPtr_get_MouseEnter_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673408);
			InstanceProxy.NativeMethodInfoPtr_get_MouseExit_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673409);
			InstanceProxy.NativeMethodInfoPtr__ctor_Public_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673393);
			InstanceProxy.NativeMethodInfoPtr_GetParent_Public_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673410);
			InstanceProxy.NativeMethodInfoPtr_SetParent_Public_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673411);
			InstanceProxy.NativeMethodInfoPtr_FindChild_Public_Instance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673412);
			InstanceProxy.NativeMethodInfoPtr_GetChildren_Public_Il2CppReferenceArray_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673413);
			InstanceProxy.NativeMethodInfoPtr_GetChildrenOfClass_Public_Il2CppReferenceArray_1_Instance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673414);
			InstanceProxy.NativeMethodInfoPtr_FindChildByClass_Public_Instance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673415);
			InstanceProxy.NativeMethodInfoPtr_IsA_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673416);
			InstanceProxy.NativeMethodInfoPtr_IsDescendantOf_Public_Boolean_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673417);
			InstanceProxy.NativeMethodInfoPtr_Destroy_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673418);
			InstanceProxy.NativeMethodInfoPtr_Delete_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673419);
			InstanceProxy.NativeMethodInfoPtr_New_Public_Static_Instance_String_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673420);
			InstanceProxy.NativeMethodInfoPtr_Clone_Public_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673421);
			InstanceProxy.NativeMethodInfoPtr_GetBounds_Public_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr, 100673422);
		}

		// Token: 0x17001627 RID: 5671
		public unsafe Instance this[string name]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128591, XrefRangeEnd = 128593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_get_Item_Public_get_Instance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
				}
			}
		}

		// Token: 0x17001628 RID: 5672
		public unsafe Instance this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128593, XrefRangeEnd = 128595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_get_Item_Public_get_Instance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
				}
			}
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x06004078 RID: 16504 RVA: 0x0012197C File Offset: 0x0011FB7C
		// (set) Token: 0x06004079 RID: 16505 RVA: 0x001219B4 File Offset: 0x0011FBB4
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128595, XrefRangeEnd = 128597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x0600407A RID: 16506 RVA: 0x001219F8 File Offset: 0x0011FBF8
		public unsafe string ClassName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_get_ClassName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x0600407B RID: 16507 RVA: 0x00121A30 File Offset: 0x0011FC30
		public unsafe DynValue Shared
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_get_Shared_Public_get_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x0600407C RID: 16508 RVA: 0x00121A70 File Offset: 0x0011FC70
		public unsafe bool ClientSpawned
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_get_ClientSpawned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x0600407D RID: 16509 RVA: 0x00121AAC File Offset: 0x0011FCAC
		// (set) Token: 0x0600407E RID: 16510 RVA: 0x00121AEC File Offset: 0x0011FCEC
		public unsafe Instance Parent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128597, XrefRangeEnd = 128599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_get_Parent_Public_get_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128599, XrefRangeEnd = 128601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_set_Parent_Public_set_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x0600407F RID: 16511 RVA: 0x00121B30 File Offset: 0x0011FD30
		public unsafe LuaEvent ChildRemoved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_get_ChildRemoved_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x06004080 RID: 16512 RVA: 0x00121B70 File Offset: 0x0011FD70
		public unsafe LuaEvent ChildAdded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_get_ChildAdded_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x06004081 RID: 16513 RVA: 0x00121BB0 File Offset: 0x0011FDB0
		public unsafe LuaEvent Touched
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_get_Touched_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x06004082 RID: 16514 RVA: 0x00121BF0 File Offset: 0x0011FDF0
		public unsafe LuaEvent TouchEnded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_get_TouchEnded_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x06004083 RID: 16515 RVA: 0x00121C30 File Offset: 0x0011FE30
		public unsafe LuaEvent Clicked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_get_Clicked_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06004084 RID: 16516 RVA: 0x00121C70 File Offset: 0x0011FE70
		public unsafe LuaEvent MouseEnter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_get_MouseEnter_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x06004085 RID: 16517 RVA: 0x00121CB0 File Offset: 0x0011FEB0
		public unsafe LuaEvent MouseExit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_get_MouseExit_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06004086 RID: 16518 RVA: 0x00121CF0 File Offset: 0x0011FEF0
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstanceProxy(Instance target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstanceProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr__ctor_Public_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004087 RID: 16519 RVA: 0x00121D3C File Offset: 0x0011FF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128601, XrefRangeEnd = 128603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instance GetParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_GetParent_Public_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x00121D7C File Offset: 0x0011FF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128603, XrefRangeEnd = 128605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParent(Instance parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_SetParent_Public_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x00121DC0 File Offset: 0x0011FFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128605, XrefRangeEnd = 128607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instance FindChild(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_FindChild_Public_Instance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
			}
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x00121E10 File Offset: 0x00120010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128607, XrefRangeEnd = 128609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Instance> GetChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_GetChildren_Public_Il2CppReferenceArray_1_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instance>>(intPtr3) : null;
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x00121E50 File Offset: 0x00120050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128609, XrefRangeEnd = 128611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Instance> GetChildrenOfClass(string className)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_GetChildrenOfClass_Public_Il2CppReferenceArray_1_Instance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instance>>(intPtr3) : null;
			}
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x00121EA0 File Offset: 0x001200A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128611, XrefRangeEnd = 128613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instance FindChildByClass(string className)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_FindChildByClass_Public_Instance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
			}
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x00121EF0 File Offset: 0x001200F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128613, XrefRangeEnd = 128615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsA(string className)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_IsA_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x00121F40 File Offset: 0x00120140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128615, XrefRangeEnd = 128617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDescendantOf(Instance parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_IsDescendantOf_Public_Boolean_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x00121F90 File Offset: 0x00120190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128617, XrefRangeEnd = 128619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy(float time = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_Destroy_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x00121FD0 File Offset: 0x001201D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete(float time = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_Delete_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x00122010 File Offset: 0x00120210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128619, XrefRangeEnd = 128623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instance New(string className, Instance parent = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_New_Public_Static_Instance_String_Instance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x00122068 File Offset: 0x00120268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128623, XrefRangeEnd = 128625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instance Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_Clone_Public_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x001220A8 File Offset: 0x001202A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128625, XrefRangeEnd = 128626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bounds GetBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceProxy.NativeMethodInfoPtr_GetBounds_Public_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Bounds>(intPtr3) : null;
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x000186F1 File Offset: 0x000168F1
		public InstanceProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x06004095 RID: 16533 RVA: 0x001220E8 File Offset: 0x001202E8
		// (set) Token: 0x06004096 RID: 16534 RVA: 0x000186FA File Offset: 0x000168FA
		public unsafe Instance target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceProxy.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceProxy.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400321A RID: 12826
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x0400321B RID: 12827
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Instance_String_0;

		// Token: 0x0400321C RID: 12828
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Instance_Int32_0;

		// Token: 0x0400321D RID: 12829
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x0400321E RID: 12830
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x0400321F RID: 12831
		private static readonly IntPtr NativeMethodInfoPtr_get_ClassName_Public_get_String_0;

		// Token: 0x04003220 RID: 12832
		private static readonly IntPtr NativeMethodInfoPtr_get_Shared_Public_get_DynValue_0;

		// Token: 0x04003221 RID: 12833
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientSpawned_Public_get_Boolean_0;

		// Token: 0x04003222 RID: 12834
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_Instance_0;

		// Token: 0x04003223 RID: 12835
		private static readonly IntPtr NativeMethodInfoPtr_set_Parent_Public_set_Void_Instance_0;

		// Token: 0x04003224 RID: 12836
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildRemoved_Public_get_LuaEvent_0;

		// Token: 0x04003225 RID: 12837
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildAdded_Public_get_LuaEvent_0;

		// Token: 0x04003226 RID: 12838
		private static readonly IntPtr NativeMethodInfoPtr_get_Touched_Public_get_LuaEvent_0;

		// Token: 0x04003227 RID: 12839
		private static readonly IntPtr NativeMethodInfoPtr_get_TouchEnded_Public_get_LuaEvent_0;

		// Token: 0x04003228 RID: 12840
		private static readonly IntPtr NativeMethodInfoPtr_get_Clicked_Public_get_LuaEvent_0;

		// Token: 0x04003229 RID: 12841
		private static readonly IntPtr NativeMethodInfoPtr_get_MouseEnter_Public_get_LuaEvent_0;

		// Token: 0x0400322A RID: 12842
		private static readonly IntPtr NativeMethodInfoPtr_get_MouseExit_Public_get_LuaEvent_0;

		// Token: 0x0400322B RID: 12843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Instance_0;

		// Token: 0x0400322C RID: 12844
		private static readonly IntPtr NativeMethodInfoPtr_GetParent_Public_Instance_0;

		// Token: 0x0400322D RID: 12845
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Public_Void_Instance_0;

		// Token: 0x0400322E RID: 12846
		private static readonly IntPtr NativeMethodInfoPtr_FindChild_Public_Instance_String_0;

		// Token: 0x0400322F RID: 12847
		private static readonly IntPtr NativeMethodInfoPtr_GetChildren_Public_Il2CppReferenceArray_1_Instance_0;

		// Token: 0x04003230 RID: 12848
		private static readonly IntPtr NativeMethodInfoPtr_GetChildrenOfClass_Public_Il2CppReferenceArray_1_Instance_String_0;

		// Token: 0x04003231 RID: 12849
		private static readonly IntPtr NativeMethodInfoPtr_FindChildByClass_Public_Instance_String_0;

		// Token: 0x04003232 RID: 12850
		private static readonly IntPtr NativeMethodInfoPtr_IsA_Public_Boolean_String_0;

		// Token: 0x04003233 RID: 12851
		private static readonly IntPtr NativeMethodInfoPtr_IsDescendantOf_Public_Boolean_Instance_0;

		// Token: 0x04003234 RID: 12852
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_Single_0;

		// Token: 0x04003235 RID: 12853
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Void_Single_0;

		// Token: 0x04003236 RID: 12854
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_Instance_String_Instance_0;

		// Token: 0x04003237 RID: 12855
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Instance_0;

		// Token: 0x04003238 RID: 12856
		private static readonly IntPtr NativeMethodInfoPtr_GetBounds_Public_Bounds_0;
	}
}
