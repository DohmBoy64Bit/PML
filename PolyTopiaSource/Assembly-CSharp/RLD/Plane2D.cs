using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000144 RID: 324
	public class Plane2D : global::Il2CppSystem.Object
	{
		// Token: 0x06001CFA RID: 7418 RVA: 0x00092F24 File Offset: 0x00091124
		// Note: this type is marked as 'beforefieldinit'.
		static Plane2D()
		{
			Il2CppClassPointerStore<Plane2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Plane2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Plane2D>.NativeClassPtr);
			Plane2D.NativeFieldInfoPtr__normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plane2D>.NativeClassPtr, "_normal");
			Plane2D.NativeFieldInfoPtr__distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plane2D>.NativeClassPtr, "_distance");
			Plane2D.NativeMethodInfoPtr_get_Normal_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane2D>.NativeClassPtr, 100667680);
			Plane2D.NativeMethodInfoPtr_set_Normal_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane2D>.NativeClassPtr, 100667681);
			Plane2D.NativeMethodInfoPtr_get_Distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane2D>.NativeClassPtr, 100667682);
			Plane2D.NativeMethodInfoPtr_set_Distance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane2D>.NativeClassPtr, 100667683);
			Plane2D.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane2D>.NativeClassPtr, 100667684);
			Plane2D.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane2D>.NativeClassPtr, 100667685);
			Plane2D.NativeMethodInfoPtr_GetDistanceToPoint_Public_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane2D>.NativeClassPtr, 100667686);
			Plane2D.NativeMethodInfoPtr_Raycast_Public_Boolean_Vector2_Vector2_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane2D>.NativeClassPtr, 100667687);
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x0009301C File Offset: 0x0009121C
		// (set) Token: 0x06001CFC RID: 7420 RVA: 0x0009305C File Offset: 0x0009125C
		public unsafe Vector2 Normal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane2D.NativeMethodInfoPtr_get_Normal_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane2D.NativeMethodInfoPtr_set_Normal_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x000930A0 File Offset: 0x000912A0
		// (set) Token: 0x06001CFE RID: 7422 RVA: 0x000930DC File Offset: 0x000912DC
		public unsafe float Distance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane2D.NativeMethodInfoPtr_get_Distance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane2D.NativeMethodInfoPtr_set_Distance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x0009311C File Offset: 0x0009131C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79075, XrefRangeEnd = 79077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane2D(Vector2 normal, float distance)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Plane2D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(normal);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane2D.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x00093178 File Offset: 0x00091378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79079, RefRangeEnd = 79080, XrefRangeStart = 79077, XrefRangeEnd = 79079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane2D(Vector2 normal, Vector2 pointOnPlane)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Plane2D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(normal);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pointOnPlane);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane2D.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x000931D8 File Offset: 0x000913D8
		[CallerCount(0)]
		public unsafe float GetDistanceToPoint(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane2D.NativeMethodInfoPtr_GetDistanceToPoint_Public_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x00093228 File Offset: 0x00091428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79080, RefRangeEnd = 79081, XrefRangeStart = 79080, XrefRangeEnd = 79080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Raycast(Vector2 rayOrigin, Vector2 rayDir, out float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rayOrigin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rayDir);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane2D.NativeMethodInfoPtr_Raycast_Public_Boolean_Vector2_Vector2_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x0000C252 File Offset: 0x0000A452
		public Plane2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x00093298 File Offset: 0x00091498
		// (set) Token: 0x06001D05 RID: 7429 RVA: 0x0000C25B File Offset: 0x0000A45B
		public unsafe Vector2 _normal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plane2D.NativeFieldInfoPtr__normal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plane2D.NativeFieldInfoPtr__normal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x000932C8 File Offset: 0x000914C8
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x0000C27A File Offset: 0x0000A47A
		public unsafe float _distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plane2D.NativeFieldInfoPtr__distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plane2D.NativeFieldInfoPtr__distance)) = value;
			}
		}

		// Token: 0x0400163C RID: 5692
		private static readonly IntPtr NativeFieldInfoPtr__normal;

		// Token: 0x0400163D RID: 5693
		private static readonly IntPtr NativeFieldInfoPtr__distance;

		// Token: 0x0400163E RID: 5694
		private static readonly IntPtr NativeMethodInfoPtr_get_Normal_Public_get_Vector2_0;

		// Token: 0x0400163F RID: 5695
		private static readonly IntPtr NativeMethodInfoPtr_set_Normal_Public_set_Void_Vector2_0;

		// Token: 0x04001640 RID: 5696
		private static readonly IntPtr NativeMethodInfoPtr_get_Distance_Public_get_Single_0;

		// Token: 0x04001641 RID: 5697
		private static readonly IntPtr NativeMethodInfoPtr_set_Distance_Public_set_Void_Single_0;

		// Token: 0x04001642 RID: 5698
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Single_0;

		// Token: 0x04001643 RID: 5699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0;

		// Token: 0x04001644 RID: 5700
		private static readonly IntPtr NativeMethodInfoPtr_GetDistanceToPoint_Public_Single_Vector2_0;

		// Token: 0x04001645 RID: 5701
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Boolean_Vector2_Vector2_byref_Single_0;
	}
}
