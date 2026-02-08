using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace RLD
{
	// Token: 0x02000046 RID: 70
	public class GizmoBehaviourCollection : Object
	{
		// Token: 0x060004A6 RID: 1190 RVA: 0x00032FB0 File Offset: 0x000311B0
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoBehaviourCollection()
		{
			Il2CppClassPointerStore<GizmoBehaviourCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoBehaviourCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoBehaviourCollection>.NativeClassPtr);
			GizmoBehaviourCollection.NativeFieldInfoPtr__behaviours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoBehaviourCollection>.NativeClassPtr, "_behaviours");
			GizmoBehaviourCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoBehaviourCollection>.NativeClassPtr, 100663972);
			GizmoBehaviourCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoBehaviourCollection>.NativeClassPtr, 100663982);
			GizmoBehaviourCollection.NativeMethodInfoPtr_Add_Public_Boolean_IGizmoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoBehaviourCollection>.NativeClassPtr, 100663973);
			GizmoBehaviourCollection.NativeMethodInfoPtr_Remove_Public_Boolean_IGizmoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoBehaviourCollection>.NativeClassPtr, 100663974);
			GizmoBehaviourCollection.NativeMethodInfoPtr_GetFirstBehaviourOfType_Public_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoBehaviourCollection>.NativeClassPtr, 100663975);
			GizmoBehaviourCollection.NativeMethodInfoPtr_GetFirstBehaviourOfType_Public_IGizmoBehaviour_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoBehaviourCollection>.NativeClassPtr, 100663976);
			GizmoBehaviourCollection.NativeMethodInfoPtr_GetBehavioursOfType_Public_List_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoBehaviourCollection>.NativeClassPtr, 100663977);
			GizmoBehaviourCollection.NativeMethodInfoPtr_GetBehavioursOfType_Public_List_1_IGizmoBehaviour_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoBehaviourCollection>.NativeClassPtr, 100663978);
			GizmoBehaviourCollection.NativeMethodInfoPtr_Contains_Public_Boolean_IGizmoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoBehaviourCollection>.NativeClassPtr, 100663979);
			GizmoBehaviourCollection.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_1_IGizmoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoBehaviourCollection>.NativeClassPtr, 100663980);
			GizmoBehaviourCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoBehaviourCollection>.NativeClassPtr, 100663981);
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x000330D0 File Offset: 0x000312D0
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59606, XrefRangeEnd = 59607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoBehaviourCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0003310C File Offset: 0x0003130C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59615, RefRangeEnd = 59616, XrefRangeStart = 59607, XrefRangeEnd = 59615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoBehaviourCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoBehaviourCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoBehaviourCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00033148 File Offset: 0x00031348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59620, RefRangeEnd = 59621, XrefRangeStart = 59616, XrefRangeEnd = 59620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Add(IGizmoBehaviour behaviour)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(behaviour);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoBehaviourCollection.NativeMethodInfoPtr_Add_Public_Boolean_IGizmoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00033198 File Offset: 0x00031398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59625, RefRangeEnd = 59626, XrefRangeStart = 59621, XrefRangeEnd = 59625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(IGizmoBehaviour behaviour)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(behaviour);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoBehaviourCollection.NativeMethodInfoPtr_Remove_Public_Boolean_IGizmoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x000331E8 File Offset: 0x000313E8
		[CallerCount(0)]
		public unsafe Type GetFirstBehaviourOfType<Type>() where Type : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoBehaviourCollection.MethodInfoStoreGeneric_GetFirstBehaviourOfType_Public_Type_0<Type>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<Type>(intPtr, false, true);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00033224 File Offset: 0x00031424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59629, RefRangeEnd = 59630, XrefRangeStart = 59626, XrefRangeEnd = 59629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IGizmoBehaviour GetFirstBehaviourOfType(Type behaviourType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(behaviourType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoBehaviourCollection.NativeMethodInfoPtr_GetFirstBehaviourOfType_Public_IGizmoBehaviour_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGizmoBehaviour>(intPtr3) : null;
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00033274 File Offset: 0x00031474
		[CallerCount(0)]
		public unsafe List<Type> GetBehavioursOfType<Type>() where Type : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoBehaviourCollection.MethodInfoStoreGeneric_GetBehavioursOfType_Public_List_1_Type_0<Type>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr3) : null;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000332B4 File Offset: 0x000314B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 59660, RefRangeEnd = 59661, XrefRangeStart = 59630, XrefRangeEnd = 59660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<IGizmoBehaviour> GetBehavioursOfType(Type behaviourType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(behaviourType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoBehaviourCollection.NativeMethodInfoPtr_GetBehavioursOfType_Public_List_1_IGizmoBehaviour_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IGizmoBehaviour>>(intPtr3) : null;
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00033304 File Offset: 0x00031504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59661, XrefRangeEnd = 59665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(IGizmoBehaviour behaviour)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(behaviour);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoBehaviourCollection.NativeMethodInfoPtr_Contains_Public_Boolean_IGizmoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00033354 File Offset: 0x00031554
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 59671, RefRangeEnd = 59684, XrefRangeStart = 59665, XrefRangeEnd = 59671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<IGizmoBehaviour> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoBehaviourCollection.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_1_IGizmoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IGizmoBehaviour>>(intPtr3) : null;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00033394 File Offset: 0x00031594
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 59671, RefRangeEnd = 59684, XrefRangeStart = 59671, XrefRangeEnd = 59684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoBehaviourCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00003AB3 File Offset: 0x00001CB3
		public GizmoBehaviourCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x000333D4 File Offset: 0x000315D4
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x00003ABC File Offset: 0x00001CBC
		public unsafe List<IGizmoBehaviour> _behaviours
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoBehaviourCollection.NativeFieldInfoPtr__behaviours);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IGizmoBehaviour>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoBehaviourCollection.NativeFieldInfoPtr__behaviours), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeFieldInfoPtr__behaviours;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Boolean_IGizmoBehaviour_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_IGizmoBehaviour_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstBehaviourOfType_Public_Type_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstBehaviourOfType_Public_IGizmoBehaviour_Type_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_GetBehavioursOfType_Public_List_1_Type_0;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr_GetBehavioursOfType_Public_List_1_IGizmoBehaviour_Type_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_IGizmoBehaviour_0;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_1_IGizmoBehaviour_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0200035A RID: 858
		private sealed class MethodInfoStoreGeneric_GetFirstBehaviourOfType_Public_Type_0<Type>
		{
			// Token: 0x04003933 RID: 14643
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GizmoBehaviourCollection.NativeMethodInfoPtr_GetFirstBehaviourOfType_Public_Type_0, Il2CppClassPointerStore<GizmoBehaviourCollection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<global::Il2CppSystem.Type>(new global::Il2CppSystem.Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Type>.NativeClassPtr)) }))));
		}

		// Token: 0x0200035B RID: 859
		private sealed class MethodInfoStoreGeneric_GetBehavioursOfType_Public_List_1_Type_0<Type>
		{
			// Token: 0x04003934 RID: 14644
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GizmoBehaviourCollection.NativeMethodInfoPtr_GetBehavioursOfType_Public_List_1_Type_0, Il2CppClassPointerStore<GizmoBehaviourCollection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<global::Il2CppSystem.Type>(new global::Il2CppSystem.Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Type>.NativeClassPtr)) }))));
		}
	}
}
