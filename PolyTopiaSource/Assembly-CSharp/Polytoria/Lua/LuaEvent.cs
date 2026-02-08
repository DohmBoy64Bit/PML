using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter;

namespace Polytoria.Lua
{
	// Token: 0x02000265 RID: 613
	public class LuaEvent : Object
	{
		// Token: 0x06002F50 RID: 12112 RVA: 0x000DA108 File Offset: 0x000D8308
		// Note: this type is marked as 'beforefieldinit'.
		static LuaEvent()
		{
			Il2CppClassPointerStore<LuaEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Lua", "LuaEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuaEvent>.NativeClassPtr);
			LuaEvent.NativeFieldInfoPtr_callbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuaEvent>.NativeClassPtr, "callbacks");
			LuaEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaEvent>.NativeClassPtr, 100670401);
			LuaEvent.NativeMethodInfoPtr_Connect_Public_Void_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaEvent>.NativeClassPtr, 100670402);
			LuaEvent.NativeMethodInfoPtr_Disconnect_Public_Void_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaEvent>.NativeClassPtr, 100670403);
			LuaEvent.NativeMethodInfoPtr_Invoke_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuaEvent>.NativeClassPtr, 100670404);
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x000DA19C File Offset: 0x000D839C
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 100010, RefRangeEnd = 100044, XrefRangeStart = 100002, XrefRangeEnd = 100010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LuaEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LuaEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x000DA1D8 File Offset: 0x000D83D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100044, XrefRangeEnd = 100050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Connect(DynValue func)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaEvent.NativeMethodInfoPtr_Connect_Public_Void_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x000DA21C File Offset: 0x000D841C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100050, XrefRangeEnd = 100056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disconnect(DynValue func)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaEvent.NativeMethodInfoPtr_Disconnect_Public_Void_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x000DA260 File Offset: 0x000D8460
		[CallerCount(70)]
		[CachedScanResults(RefRangeStart = 100088, RefRangeEnd = 100158, XrefRangeStart = 100056, XrefRangeEnd = 100088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuaEvent.NativeMethodInfoPtr_Invoke_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x00012F5F File Offset: 0x0001115F
		public LuaEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x06002F56 RID: 12118 RVA: 0x000DA2B0 File Offset: 0x000D84B0
		// (set) Token: 0x06002F57 RID: 12119 RVA: 0x00012F68 File Offset: 0x00011168
		public unsafe List<DynValue> callbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LuaEvent.NativeFieldInfoPtr_callbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DynValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LuaEvent.NativeFieldInfoPtr_callbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002429 RID: 9257
		private static readonly IntPtr NativeFieldInfoPtr_callbacks;

		// Token: 0x0400242A RID: 9258
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400242B RID: 9259
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Void_DynValue_0;

		// Token: 0x0400242C RID: 9260
		private static readonly IntPtr NativeMethodInfoPtr_Disconnect_Public_Void_DynValue_0;

		// Token: 0x0400242D RID: 9261
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_Il2CppReferenceArray_1_Object_0;
	}
}
