using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000138 RID: 312
	public class InputDeviceDeltaCapture : global::Il2CppSystem.Object
	{
		// Token: 0x06001C70 RID: 7280 RVA: 0x000908C0 File Offset: 0x0008EAC0
		// Note: this type is marked as 'beforefieldinit'.
		static InputDeviceDeltaCapture()
		{
			Il2CppClassPointerStore<InputDeviceDeltaCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "InputDeviceDeltaCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDeviceDeltaCapture>.NativeClassPtr);
			InputDeviceDeltaCapture.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceDeltaCapture>.NativeClassPtr, "_id");
			InputDeviceDeltaCapture.NativeFieldInfoPtr__origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceDeltaCapture>.NativeClassPtr, "_origin");
			InputDeviceDeltaCapture.NativeFieldInfoPtr__delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceDeltaCapture>.NativeClassPtr, "_delta");
			InputDeviceDeltaCapture.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceDeltaCapture>.NativeClassPtr, 100667576);
			InputDeviceDeltaCapture.NativeMethodInfoPtr_get_Origin_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceDeltaCapture>.NativeClassPtr, 100667577);
			InputDeviceDeltaCapture.NativeMethodInfoPtr_get_Delta_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceDeltaCapture>.NativeClassPtr, 100667578);
			InputDeviceDeltaCapture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceDeltaCapture>.NativeClassPtr, 100667579);
			InputDeviceDeltaCapture.NativeMethodInfoPtr_Update_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceDeltaCapture>.NativeClassPtr, 100667580);
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x00090990 File Offset: 0x0008EB90
		public unsafe int Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceDeltaCapture.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x000909CC File Offset: 0x0008EBCC
		public unsafe Vector3 Origin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceDeltaCapture.NativeMethodInfoPtr_get_Origin_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x00090A0C File Offset: 0x0008EC0C
		public unsafe Vector3 Delta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceDeltaCapture.NativeMethodInfoPtr_get_Delta_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x00090A4C File Offset: 0x0008EC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78611, XrefRangeEnd = 78612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDeviceDeltaCapture(int id, Vector3 origin)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDeviceDeltaCapture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(origin);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceDeltaCapture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x00090AA8 File Offset: 0x0008ECA8
		[CallerCount(0)]
		public unsafe void Update(Vector3 devicePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(devicePosition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceDeltaCapture.NativeMethodInfoPtr_Update_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0000C0ED File Offset: 0x0000A2ED
		public InputDeviceDeltaCapture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x00090AEC File Offset: 0x0008ECEC
		// (set) Token: 0x06001C78 RID: 7288 RVA: 0x0000C0F6 File Offset: 0x0000A2F6
		public unsafe int _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceDeltaCapture.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceDeltaCapture.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x00090B14 File Offset: 0x0008ED14
		// (set) Token: 0x06001C7A RID: 7290 RVA: 0x0000C111 File Offset: 0x0000A311
		public unsafe Vector3 _origin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceDeltaCapture.NativeFieldInfoPtr__origin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceDeltaCapture.NativeFieldInfoPtr__origin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x00090B44 File Offset: 0x0008ED44
		// (set) Token: 0x06001C7C RID: 7292 RVA: 0x0000C130 File Offset: 0x0000A330
		public unsafe Vector3 _delta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceDeltaCapture.NativeFieldInfoPtr__delta);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceDeltaCapture.NativeFieldInfoPtr__delta), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015AD RID: 5549
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x040015AE RID: 5550
		private static readonly IntPtr NativeFieldInfoPtr__origin;

		// Token: 0x040015AF RID: 5551
		private static readonly IntPtr NativeFieldInfoPtr__delta;

		// Token: 0x040015B0 RID: 5552
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x040015B1 RID: 5553
		private static readonly IntPtr NativeMethodInfoPtr_get_Origin_Public_get_Vector3_0;

		// Token: 0x040015B2 RID: 5554
		private static readonly IntPtr NativeMethodInfoPtr_get_Delta_Public_get_Vector3_0;

		// Token: 0x040015B3 RID: 5555
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Vector3_0;

		// Token: 0x040015B4 RID: 5556
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_Vector3_0;
	}
}
