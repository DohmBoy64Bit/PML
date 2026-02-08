using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002F1 RID: 753
	public class RemoveEventProxy : InstanceProxy
	{
		// Token: 0x0600421E RID: 16926 RVA: 0x00129364 File Offset: 0x00127564
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveEventProxy()
		{
			Il2CppClassPointerStore<RemoveEventProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "RemoveEventProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveEventProxy>.NativeClassPtr);
			RemoveEventProxy.NativeFieldInfoPtr_remoteEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveEventProxy>.NativeClassPtr, "remoteEvent");
			RemoveEventProxy.NativeMethodInfoPtr_get_Invoked_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveEventProxy>.NativeClassPtr, 100673743);
			RemoveEventProxy.NativeMethodInfoPtr__ctor_Public_Void_RemoteEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveEventProxy>.NativeClassPtr, 100673742);
			RemoveEventProxy.NativeMethodInfoPtr_Invoke_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveEventProxy>.NativeClassPtr, 100673744);
			RemoveEventProxy.NativeMethodInfoPtr_Invoke_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveEventProxy>.NativeClassPtr, 100673745);
			RemoveEventProxy.NativeMethodInfoPtr_Invoke_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveEventProxy>.NativeClassPtr, 100673746);
			RemoveEventProxy.NativeMethodInfoPtr_Invoke_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveEventProxy>.NativeClassPtr, 100673747);
			RemoveEventProxy.NativeMethodInfoPtr_Invoke_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveEventProxy>.NativeClassPtr, 100673748);
			RemoveEventProxy.NativeMethodInfoPtr_Invoke_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveEventProxy>.NativeClassPtr, 100673749);
			RemoveEventProxy.NativeMethodInfoPtr_Invoke_Public_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveEventProxy>.NativeClassPtr, 100673750);
		}

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x0600421F RID: 16927 RVA: 0x0012945C File Offset: 0x0012765C
		public unsafe LuaEvent Invoked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveEventProxy.NativeMethodInfoPtr_get_Invoked_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x0012949C File Offset: 0x0012769C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoveEventProxy(RemoteEvent target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveEventProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveEventProxy.NativeMethodInfoPtr__ctor_Public_Void_RemoteEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x001294E8 File Offset: 0x001276E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128974, XrefRangeEnd = 128976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(string val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveEventProxy.NativeMethodInfoPtr_Invoke_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x0012952C File Offset: 0x0012772C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128976, XrefRangeEnd = 128978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveEventProxy.NativeMethodInfoPtr_Invoke_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x0012956C File Offset: 0x0012776C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128978, XrefRangeEnd = 128980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveEventProxy.NativeMethodInfoPtr_Invoke_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004224 RID: 16932 RVA: 0x001295AC File Offset: 0x001277AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128980, XrefRangeEnd = 128982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(int val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveEventProxy.NativeMethodInfoPtr_Invoke_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004225 RID: 16933 RVA: 0x001295EC File Offset: 0x001277EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128982, XrefRangeEnd = 128983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Vector3 val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveEventProxy.NativeMethodInfoPtr_Invoke_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x00129630 File Offset: 0x00127830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128983, XrefRangeEnd = 128984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Color val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveEventProxy.NativeMethodInfoPtr_Invoke_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x00129674 File Offset: 0x00127874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128984, XrefRangeEnd = 128986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Instance val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveEventProxy.NativeMethodInfoPtr_Invoke_Public_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x000189E9 File Offset: 0x00016BE9
		public RemoveEventProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x06004229 RID: 16937 RVA: 0x001296B8 File Offset: 0x001278B8
		// (set) Token: 0x0600422A RID: 16938 RVA: 0x000189F2 File Offset: 0x00016BF2
		public unsafe RemoteEvent remoteEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoveEventProxy.NativeFieldInfoPtr_remoteEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemoteEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoveEventProxy.NativeFieldInfoPtr_remoteEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400338A RID: 13194
		private static readonly IntPtr NativeFieldInfoPtr_remoteEvent;

		// Token: 0x0400338B RID: 13195
		private static readonly IntPtr NativeMethodInfoPtr_get_Invoked_Public_get_LuaEvent_0;

		// Token: 0x0400338C RID: 13196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RemoteEvent_0;

		// Token: 0x0400338D RID: 13197
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_String_0;

		// Token: 0x0400338E RID: 13198
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_Boolean_0;

		// Token: 0x0400338F RID: 13199
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_Single_0;

		// Token: 0x04003390 RID: 13200
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_Int32_0;

		// Token: 0x04003391 RID: 13201
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_Vector3_0;

		// Token: 0x04003392 RID: 13202
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_Color_0;

		// Token: 0x04003393 RID: 13203
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_Instance_0;
	}
}
