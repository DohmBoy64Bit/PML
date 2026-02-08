using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Mirror;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002A6 RID: 678
	public class RemoteEvent : Instance
	{
		// Token: 0x060039D4 RID: 14804 RVA: 0x00105A2C File Offset: 0x00103C2C
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteEvent()
		{
			Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "RemoteEvent");
			RemoteEvent.NativeFieldInfoPtr_Invoked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, "Invoked");
			RemoteEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672161);
			RemoteEvent.NativeMethodInfoPtr_Invoke_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672147);
			RemoteEvent.NativeMethodInfoPtr_Invoke_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672148);
			RemoteEvent.NativeMethodInfoPtr_Invoke_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672149);
			RemoteEvent.NativeMethodInfoPtr_Invoke_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672150);
			RemoteEvent.NativeMethodInfoPtr_Invoke_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672151);
			RemoteEvent.NativeMethodInfoPtr_Invoke_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672152);
			RemoteEvent.NativeMethodInfoPtr_Invoke_Public_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672153);
			RemoteEvent.NativeMethodInfoPtr_CmdInvokeString_Private_Void_String_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672154);
			RemoteEvent.NativeMethodInfoPtr_CmdInvokeBool_Private_Void_Boolean_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672155);
			RemoteEvent.NativeMethodInfoPtr_CmdInvokeFloat_Private_Void_Single_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672156);
			RemoteEvent.NativeMethodInfoPtr_CmdInvokeInt_Private_Void_Int32_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672157);
			RemoteEvent.NativeMethodInfoPtr_CmdInvokeVec3_Private_Void_Vector3_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672158);
			RemoteEvent.NativeMethodInfoPtr_CmdInvokeColor_Private_Void_Color_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672159);
			RemoteEvent.NativeMethodInfoPtr_CmdInvokeInstance_Private_Void_Instance_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672160);
			RemoteEvent.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672162);
			RemoteEvent.NativeMethodInfoPtr_UserCode_CmdInvokeString__String__NetworkConnectionToClient_Protected_Void_String_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672163);
			RemoteEvent.NativeMethodInfoPtr_InvokeUserCode_CmdInvokeString__String__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672164);
			RemoteEvent.NativeMethodInfoPtr_UserCode_CmdInvokeBool__Boolean__NetworkConnectionToClient_Protected_Void_Boolean_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672165);
			RemoteEvent.NativeMethodInfoPtr_InvokeUserCode_CmdInvokeBool__Boolean__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672166);
			RemoteEvent.NativeMethodInfoPtr_UserCode_CmdInvokeFloat__Single__NetworkConnectionToClient_Protected_Void_Single_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672167);
			RemoteEvent.NativeMethodInfoPtr_InvokeUserCode_CmdInvokeFloat__Single__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672168);
			RemoteEvent.NativeMethodInfoPtr_UserCode_CmdInvokeInt__Int32__NetworkConnectionToClient_Protected_Void_Int32_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672169);
			RemoteEvent.NativeMethodInfoPtr_InvokeUserCode_CmdInvokeInt__Int32__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672170);
			RemoteEvent.NativeMethodInfoPtr_UserCode_CmdInvokeVec3__Vector3__NetworkConnectionToClient_Protected_Void_Vector3_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672171);
			RemoteEvent.NativeMethodInfoPtr_InvokeUserCode_CmdInvokeVec3__Vector3__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672172);
			RemoteEvent.NativeMethodInfoPtr_UserCode_CmdInvokeColor__Color__NetworkConnectionToClient_Protected_Void_Color_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672173);
			RemoteEvent.NativeMethodInfoPtr_InvokeUserCode_CmdInvokeColor__Color__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672174);
			RemoteEvent.NativeMethodInfoPtr_UserCode_CmdInvokeInstance__Instance__NetworkConnectionToClient_Protected_Void_Instance_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672175);
			RemoteEvent.NativeMethodInfoPtr_InvokeUserCode_CmdInvokeInstance__Instance__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr, 100672176);
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x00105CC0 File Offset: 0x00103EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117290, XrefRangeEnd = 117299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoteEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x00105CFC File Offset: 0x00103EFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117320, RefRangeEnd = 117321, XrefRangeStart = 117299, XrefRangeEnd = 117320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(string val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_Invoke_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x00105D40 File Offset: 0x00103F40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117342, RefRangeEnd = 117343, XrefRangeStart = 117321, XrefRangeEnd = 117342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_Invoke_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x00105D80 File Offset: 0x00103F80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117364, RefRangeEnd = 117365, XrefRangeStart = 117343, XrefRangeEnd = 117364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_Invoke_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x00105DC0 File Offset: 0x00103FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117386, RefRangeEnd = 117387, XrefRangeStart = 117365, XrefRangeEnd = 117386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(int val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_Invoke_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x00105E00 File Offset: 0x00104000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117408, RefRangeEnd = 117409, XrefRangeStart = 117387, XrefRangeEnd = 117408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Vector3 val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_Invoke_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x00105E44 File Offset: 0x00104044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117430, RefRangeEnd = 117431, XrefRangeStart = 117409, XrefRangeEnd = 117430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Color val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_Invoke_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039DC RID: 14812 RVA: 0x00105E88 File Offset: 0x00104088
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117452, RefRangeEnd = 117453, XrefRangeStart = 117431, XrefRangeEnd = 117452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Instance val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_Invoke_Public_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x00105ECC File Offset: 0x001040CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117320, RefRangeEnd = 117321, XrefRangeStart = 117320, XrefRangeEnd = 117321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdInvokeString(string val, NetworkConnectionToClient sender = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(val);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_CmdInvokeString_Private_Void_String_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039DE RID: 14814 RVA: 0x00105F20 File Offset: 0x00104120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117342, RefRangeEnd = 117343, XrefRangeStart = 117342, XrefRangeEnd = 117343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdInvokeBool(bool val, NetworkConnectionToClient sender = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_CmdInvokeBool_Private_Void_Boolean_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039DF RID: 14815 RVA: 0x00105F70 File Offset: 0x00104170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117364, RefRangeEnd = 117365, XrefRangeStart = 117364, XrefRangeEnd = 117365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdInvokeFloat(float val, NetworkConnectionToClient sender = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_CmdInvokeFloat_Private_Void_Single_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039E0 RID: 14816 RVA: 0x00105FC0 File Offset: 0x001041C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117386, RefRangeEnd = 117387, XrefRangeStart = 117386, XrefRangeEnd = 117387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdInvokeInt(int val, NetworkConnectionToClient sender = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_CmdInvokeInt_Private_Void_Int32_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x00106010 File Offset: 0x00104210
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117408, RefRangeEnd = 117409, XrefRangeStart = 117408, XrefRangeEnd = 117409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdInvokeVec3(Vector3 val, NetworkConnectionToClient sender = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_CmdInvokeVec3_Private_Void_Vector3_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x00106064 File Offset: 0x00104264
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117430, RefRangeEnd = 117431, XrefRangeStart = 117430, XrefRangeEnd = 117431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdInvokeColor(Color val, NetworkConnectionToClient sender = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_CmdInvokeColor_Private_Void_Color_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x001060B8 File Offset: 0x001042B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117452, RefRangeEnd = 117453, XrefRangeStart = 117452, XrefRangeEnd = 117453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdInvokeInstance(Instance val, NetworkConnectionToClient sender = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_CmdInvokeInstance_Private_Void_Instance_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x0010610C File Offset: 0x0010430C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemoteEvent.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039E5 RID: 14821 RVA: 0x00106154 File Offset: 0x00104354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117453, XrefRangeEnd = 117464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdInvokeString__String__NetworkConnectionToClient(string val, NetworkConnectionToClient sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(val);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_UserCode_CmdInvokeString__String__NetworkConnectionToClient_Protected_Void_String_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039E6 RID: 14822 RVA: 0x001061A8 File Offset: 0x001043A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117464, XrefRangeEnd = 117487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdInvokeString__String__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_InvokeUserCode_CmdInvokeString__String__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039E7 RID: 14823 RVA: 0x00106204 File Offset: 0x00104404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117487, XrefRangeEnd = 117500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdInvokeBool__Boolean__NetworkConnectionToClient(bool val, NetworkConnectionToClient sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_UserCode_CmdInvokeBool__Boolean__NetworkConnectionToClient_Protected_Void_Boolean_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x00106254 File Offset: 0x00104454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117500, XrefRangeEnd = 117525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdInvokeBool__Boolean__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_InvokeUserCode_CmdInvokeBool__Boolean__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x001062B0 File Offset: 0x001044B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117525, XrefRangeEnd = 117538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdInvokeFloat__Single__NetworkConnectionToClient(float val, NetworkConnectionToClient sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_UserCode_CmdInvokeFloat__Single__NetworkConnectionToClient_Protected_Void_Single_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x00106300 File Offset: 0x00104500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117538, XrefRangeEnd = 117563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdInvokeFloat__Single__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_InvokeUserCode_CmdInvokeFloat__Single__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039EB RID: 14827 RVA: 0x0010635C File Offset: 0x0010455C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117563, XrefRangeEnd = 117576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdInvokeInt__Int32__NetworkConnectionToClient(int val, NetworkConnectionToClient sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_UserCode_CmdInvokeInt__Int32__NetworkConnectionToClient_Protected_Void_Int32_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x001063AC File Offset: 0x001045AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117576, XrefRangeEnd = 117601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdInvokeInt__Int32__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_InvokeUserCode_CmdInvokeInt__Int32__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x00106408 File Offset: 0x00104608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117601, XrefRangeEnd = 117615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdInvokeVec3__Vector3__NetworkConnectionToClient(Vector3 val, NetworkConnectionToClient sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_UserCode_CmdInvokeVec3__Vector3__NetworkConnectionToClient_Protected_Void_Vector3_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x0010645C File Offset: 0x0010465C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117615, XrefRangeEnd = 117641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdInvokeVec3__Vector3__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_InvokeUserCode_CmdInvokeVec3__Vector3__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x001064B8 File Offset: 0x001046B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117641, XrefRangeEnd = 117655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdInvokeColor__Color__NetworkConnectionToClient(Color val, NetworkConnectionToClient sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_UserCode_CmdInvokeColor__Color__NetworkConnectionToClient_Protected_Void_Color_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x0010650C File Offset: 0x0010470C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117655, XrefRangeEnd = 117681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdInvokeColor__Color__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_InvokeUserCode_CmdInvokeColor__Color__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x00106568 File Offset: 0x00104768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117681, XrefRangeEnd = 117692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdInvokeInstance__Instance__NetworkConnectionToClient(Instance val, NetworkConnectionToClient sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_UserCode_CmdInvokeInstance__Instance__NetworkConnectionToClient_Protected_Void_Instance_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x001065BC File Offset: 0x001047BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117692, XrefRangeEnd = 117717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdInvokeInstance__Instance__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteEvent.NativeMethodInfoPtr_InvokeUserCode_CmdInvokeInstance__Instance__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x000166EA File Offset: 0x000148EA
		public RemoteEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x060039F4 RID: 14836 RVA: 0x00106618 File Offset: 0x00104818
		// (set) Token: 0x060039F5 RID: 14837 RVA: 0x000166F3 File Offset: 0x000148F3
		public unsafe LuaEvent Invoked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteEvent.NativeFieldInfoPtr_Invoked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteEvent.NativeFieldInfoPtr_Invoked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002CDB RID: 11483
		private static readonly IntPtr NativeFieldInfoPtr_Invoked;

		// Token: 0x04002CDC RID: 11484
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002CDD RID: 11485
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_String_0;

		// Token: 0x04002CDE RID: 11486
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_Boolean_0;

		// Token: 0x04002CDF RID: 11487
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_Single_0;

		// Token: 0x04002CE0 RID: 11488
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_Int32_0;

		// Token: 0x04002CE1 RID: 11489
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_Vector3_0;

		// Token: 0x04002CE2 RID: 11490
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_Color_0;

		// Token: 0x04002CE3 RID: 11491
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_Instance_0;

		// Token: 0x04002CE4 RID: 11492
		private static readonly IntPtr NativeMethodInfoPtr_CmdInvokeString_Private_Void_String_NetworkConnectionToClient_0;

		// Token: 0x04002CE5 RID: 11493
		private static readonly IntPtr NativeMethodInfoPtr_CmdInvokeBool_Private_Void_Boolean_NetworkConnectionToClient_0;

		// Token: 0x04002CE6 RID: 11494
		private static readonly IntPtr NativeMethodInfoPtr_CmdInvokeFloat_Private_Void_Single_NetworkConnectionToClient_0;

		// Token: 0x04002CE7 RID: 11495
		private static readonly IntPtr NativeMethodInfoPtr_CmdInvokeInt_Private_Void_Int32_NetworkConnectionToClient_0;

		// Token: 0x04002CE8 RID: 11496
		private static readonly IntPtr NativeMethodInfoPtr_CmdInvokeVec3_Private_Void_Vector3_NetworkConnectionToClient_0;

		// Token: 0x04002CE9 RID: 11497
		private static readonly IntPtr NativeMethodInfoPtr_CmdInvokeColor_Private_Void_Color_NetworkConnectionToClient_0;

		// Token: 0x04002CEA RID: 11498
		private static readonly IntPtr NativeMethodInfoPtr_CmdInvokeInstance_Private_Void_Instance_NetworkConnectionToClient_0;

		// Token: 0x04002CEB RID: 11499
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002CEC RID: 11500
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdInvokeString__String__NetworkConnectionToClient_Protected_Void_String_NetworkConnectionToClient_0;

		// Token: 0x04002CED RID: 11501
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdInvokeString__String__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002CEE RID: 11502
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdInvokeBool__Boolean__NetworkConnectionToClient_Protected_Void_Boolean_NetworkConnectionToClient_0;

		// Token: 0x04002CEF RID: 11503
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdInvokeBool__Boolean__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002CF0 RID: 11504
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdInvokeFloat__Single__NetworkConnectionToClient_Protected_Void_Single_NetworkConnectionToClient_0;

		// Token: 0x04002CF1 RID: 11505
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdInvokeFloat__Single__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002CF2 RID: 11506
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdInvokeInt__Int32__NetworkConnectionToClient_Protected_Void_Int32_NetworkConnectionToClient_0;

		// Token: 0x04002CF3 RID: 11507
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdInvokeInt__Int32__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002CF4 RID: 11508
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdInvokeVec3__Vector3__NetworkConnectionToClient_Protected_Void_Vector3_NetworkConnectionToClient_0;

		// Token: 0x04002CF5 RID: 11509
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdInvokeVec3__Vector3__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002CF6 RID: 11510
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdInvokeColor__Color__NetworkConnectionToClient_Protected_Void_Color_NetworkConnectionToClient_0;

		// Token: 0x04002CF7 RID: 11511
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdInvokeColor__Color__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002CF8 RID: 11512
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdInvokeInstance__Instance__NetworkConnectionToClient_Protected_Void_Instance_NetworkConnectionToClient_0;

		// Token: 0x04002CF9 RID: 11513
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdInvokeInstance__Instance__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;
	}
}
