using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Polytoria.Datamodel
{
	// Token: 0x02000277 RID: 631
	[StructLayout(2)]
	public struct ClientSyncState
	{
		// Token: 0x060031AF RID: 12719 RVA: 0x000E3AA8 File Offset: 0x000E1CA8
		// Note: this type is marked as 'beforefieldinit'.
		static ClientSyncState()
		{
			Il2CppClassPointerStore<ClientSyncState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "ClientSyncState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientSyncState>.NativeClassPtr);
			ClientSyncState.NativeFieldInfoPtr_nextSyncTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSyncState>.NativeClassPtr, "nextSyncTime");
			ClientSyncState.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSyncState>.NativeClassPtr, "velocity");
			ClientSyncState.NativeFieldInfoPtr_angularVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSyncState>.NativeClassPtr, "angularVelocity");
			ClientSyncState.NativeFieldInfoPtr_isKinematic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSyncState>.NativeClassPtr, "isKinematic");
			ClientSyncState.NativeFieldInfoPtr_useGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSyncState>.NativeClassPtr, "useGravity");
			ClientSyncState.NativeFieldInfoPtr_drag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSyncState>.NativeClassPtr, "drag");
			ClientSyncState.NativeFieldInfoPtr_angularDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSyncState>.NativeClassPtr, "angularDrag");
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x00013C3C File Offset: 0x00011E3C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientSyncState>.NativeClassPtr, ref this));
		}

		// Token: 0x040025FC RID: 9724
		private static readonly IntPtr NativeFieldInfoPtr_nextSyncTime;

		// Token: 0x040025FD RID: 9725
		private static readonly IntPtr NativeFieldInfoPtr_velocity;

		// Token: 0x040025FE RID: 9726
		private static readonly IntPtr NativeFieldInfoPtr_angularVelocity;

		// Token: 0x040025FF RID: 9727
		private static readonly IntPtr NativeFieldInfoPtr_isKinematic;

		// Token: 0x04002600 RID: 9728
		private static readonly IntPtr NativeFieldInfoPtr_useGravity;

		// Token: 0x04002601 RID: 9729
		private static readonly IntPtr NativeFieldInfoPtr_drag;

		// Token: 0x04002602 RID: 9730
		private static readonly IntPtr NativeFieldInfoPtr_angularDrag;

		// Token: 0x04002603 RID: 9731
		[FieldOffset(0)]
		public float nextSyncTime;

		// Token: 0x04002604 RID: 9732
		[FieldOffset(4)]
		public IntPtr velocity;

		// Token: 0x04002605 RID: 9733
		[FieldOffset(16)]
		public IntPtr angularVelocity;

		// Token: 0x04002606 RID: 9734
		[FieldOffset(28)]
		[MarshalAs(4)]
		public bool isKinematic;

		// Token: 0x04002607 RID: 9735
		[FieldOffset(29)]
		[MarshalAs(4)]
		public bool useGravity;

		// Token: 0x04002608 RID: 9736
		[FieldOffset(32)]
		public float drag;

		// Token: 0x04002609 RID: 9737
		[FieldOffset(36)]
		public float angularDrag;
	}
}
