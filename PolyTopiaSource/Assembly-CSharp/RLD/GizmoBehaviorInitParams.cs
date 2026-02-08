using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace RLD
{
	// Token: 0x02000047 RID: 71
	public sealed class GizmoBehaviorInitParams : ValueType
	{
		// Token: 0x060004B5 RID: 1205 RVA: 0x00003ADB File Offset: 0x00001CDB
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoBehaviorInitParams()
		{
			Il2CppClassPointerStore<GizmoBehaviorInitParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoBehaviorInitParams");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoBehaviorInitParams>.NativeClassPtr);
			GizmoBehaviorInitParams.NativeFieldInfoPtr_Gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoBehaviorInitParams>.NativeClassPtr, "Gizmo");
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00003B14 File Offset: 0x00001D14
		public GizmoBehaviorInitParams(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00003B1D File Offset: 0x00001D1D
		public GizmoBehaviorInitParams()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoBehaviorInitParams>.NativeClassPtr))
		{
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00033404 File Offset: 0x00031604
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00003B2F File Offset: 0x00001D2F
		public unsafe Gizmo Gizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoBehaviorInitParams.NativeFieldInfoPtr_Gizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoBehaviorInitParams.NativeFieldInfoPtr_Gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeFieldInfoPtr_Gizmo;
	}
}
