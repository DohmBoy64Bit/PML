using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace RLD
{
	// Token: 0x0200018F RID: 399
	public static class GameObjectTypeHelper : Object
	{
		// Token: 0x06001F0A RID: 7946 RVA: 0x0009D3B0 File Offset: 0x0009B5B0
		// Note: this type is marked as 'beforefieldinit'.
		static GameObjectTypeHelper()
		{
			Il2CppClassPointerStore<GameObjectTypeHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GameObjectTypeHelper");
			GameObjectTypeHelper.NativeFieldInfoPtr__numTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectTypeHelper>.NativeClassPtr, "_numTypes");
			GameObjectTypeHelper.NativeFieldInfoPtr__allObjectTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectTypeHelper>.NativeClassPtr, "_allObjectTypes");
			GameObjectTypeHelper.NativeFieldInfoPtr__allCombined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectTypeHelper>.NativeClassPtr, "_allCombined");
			GameObjectTypeHelper.NativeMethodInfoPtr_get_NumTypes_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectTypeHelper>.NativeClassPtr, 100668025);
			GameObjectTypeHelper.NativeMethodInfoPtr_get_AllObjectTypes_Public_Static_get_Il2CppStructArray_1_GameObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectTypeHelper>.NativeClassPtr, 100668026);
			GameObjectTypeHelper.NativeMethodInfoPtr_get_AllCombined_Public_Static_get_GameObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectTypeHelper>.NativeClassPtr, 100668027);
			GameObjectTypeHelper.NativeMethodInfoPtr_Is3DObjectType_Public_Static_Boolean_GameObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectTypeHelper>.NativeClassPtr, 100668028);
			GameObjectTypeHelper.NativeMethodInfoPtr_Is2DObjectType_Public_Static_Boolean_GameObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectTypeHelper>.NativeClassPtr, 100668029);
			GameObjectTypeHelper.NativeMethodInfoPtr_HasVolume_Public_Static_Boolean_GameObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectTypeHelper>.NativeClassPtr, 100668030);
			GameObjectTypeHelper.NativeMethodInfoPtr_IsTypeBitSet_Public_Static_Boolean_Int32_GameObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectTypeHelper>.NativeClassPtr, 100668031);
			GameObjectTypeHelper.NativeMethodInfoPtr_SetTypeBit_Public_Static_Int32_Int32_GameObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectTypeHelper>.NativeClassPtr, 100668032);
			GameObjectTypeHelper.NativeMethodInfoPtr_ClearTypeBit_Public_Static_Int32_Int32_GameObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectTypeHelper>.NativeClassPtr, 100668033);
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06001F0B RID: 7947 RVA: 0x0009D4C8 File Offset: 0x0009B6C8
		public unsafe static int NumTypes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83119, XrefRangeEnd = 83123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectTypeHelper.NativeMethodInfoPtr_get_NumTypes_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x0009D4F8 File Offset: 0x0009B6F8
		public unsafe static Il2CppStructArray<GameObjectType> AllObjectTypes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83123, XrefRangeEnd = 83131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectTypeHelper.NativeMethodInfoPtr_get_AllObjectTypes_Public_Static_get_Il2CppStructArray_1_GameObjectType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GameObjectType>>(intPtr3) : null;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06001F0D RID: 7949 RVA: 0x0009D52C File Offset: 0x0009B72C
		public unsafe static GameObjectType AllCombined
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83131, XrefRangeEnd = 83135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectTypeHelper.NativeMethodInfoPtr_get_AllCombined_Public_Static_get_GameObjectType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObjectType>(intPtr3) : null;
			}
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x0009D560 File Offset: 0x0009B760
		[CallerCount(0)]
		public unsafe static bool Is3DObjectType(GameObjectType objectType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectTypeHelper.NativeMethodInfoPtr_Is3DObjectType_Public_Static_Boolean_GameObjectType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x0009D5A4 File Offset: 0x0009B7A4
		[CallerCount(0)]
		public unsafe static bool Is2DObjectType(GameObjectType objectType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectTypeHelper.NativeMethodInfoPtr_Is2DObjectType_Public_Static_Boolean_GameObjectType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x0009D5E8 File Offset: 0x0009B7E8
		[CallerCount(0)]
		public unsafe static bool HasVolume(GameObjectType objectType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectTypeHelper.NativeMethodInfoPtr_HasVolume_Public_Static_Boolean_GameObjectType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x0009D62C File Offset: 0x0009B82C
		[CallerCount(0)]
		public unsafe static bool IsTypeBitSet(int objectTypeMask, GameObjectType typeBit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectTypeMask;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeBit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectTypeHelper.NativeMethodInfoPtr_IsTypeBitSet_Public_Static_Boolean_Int32_GameObjectType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x0009D67C File Offset: 0x0009B87C
		[CallerCount(0)]
		public unsafe static int SetTypeBit(int objectTypeMask, GameObjectType typeBit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectTypeMask;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeBit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectTypeHelper.NativeMethodInfoPtr_SetTypeBit_Public_Static_Int32_Int32_GameObjectType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x0009D6CC File Offset: 0x0009B8CC
		[CallerCount(0)]
		public unsafe static int ClearTypeBit(int objectTypeMask, GameObjectType typeBit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectTypeMask;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeBit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectTypeHelper.NativeMethodInfoPtr_ClearTypeBit_Public_Static_Int32_Int32_GameObjectType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x0000CAA4 File Offset: 0x0000ACA4
		public GameObjectTypeHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x0009D71C File Offset: 0x0009B91C
		// (set) Token: 0x06001F16 RID: 7958 RVA: 0x0000CAAD File Offset: 0x0000ACAD
		public unsafe static int _numTypes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameObjectTypeHelper.NativeFieldInfoPtr__numTypes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameObjectTypeHelper.NativeFieldInfoPtr__numTypes, (void*)(&value));
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x0009D738 File Offset: 0x0009B938
		// (set) Token: 0x06001F18 RID: 7960 RVA: 0x0000CABB File Offset: 0x0000ACBB
		public unsafe static List<GameObjectType> _allObjectTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GameObjectTypeHelper.NativeFieldInfoPtr__allObjectTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObjectType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameObjectTypeHelper.NativeFieldInfoPtr__allObjectTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06001F19 RID: 7961 RVA: 0x0009D760 File Offset: 0x0009B960
		// (set) Token: 0x06001F1A RID: 7962 RVA: 0x0000CACD File Offset: 0x0000ACCD
		public unsafe static GameObjectType _allCombined
		{
			get
			{
				GameObjectType gameObjectType;
				IL2CPP.il2cpp_field_static_get_value(GameObjectTypeHelper.NativeFieldInfoPtr__allCombined, (void*)(&gameObjectType));
				return gameObjectType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameObjectTypeHelper.NativeFieldInfoPtr__allCombined, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001859 RID: 6233
		private static readonly IntPtr NativeFieldInfoPtr__numTypes;

		// Token: 0x0400185A RID: 6234
		private static readonly IntPtr NativeFieldInfoPtr__allObjectTypes;

		// Token: 0x0400185B RID: 6235
		private static readonly IntPtr NativeFieldInfoPtr__allCombined;

		// Token: 0x0400185C RID: 6236
		private static readonly IntPtr NativeMethodInfoPtr_get_NumTypes_Public_Static_get_Int32_0;

		// Token: 0x0400185D RID: 6237
		private static readonly IntPtr NativeMethodInfoPtr_get_AllObjectTypes_Public_Static_get_Il2CppStructArray_1_GameObjectType_0;

		// Token: 0x0400185E RID: 6238
		private static readonly IntPtr NativeMethodInfoPtr_get_AllCombined_Public_Static_get_GameObjectType_0;

		// Token: 0x0400185F RID: 6239
		private static readonly IntPtr NativeMethodInfoPtr_Is3DObjectType_Public_Static_Boolean_GameObjectType_0;

		// Token: 0x04001860 RID: 6240
		private static readonly IntPtr NativeMethodInfoPtr_Is2DObjectType_Public_Static_Boolean_GameObjectType_0;

		// Token: 0x04001861 RID: 6241
		private static readonly IntPtr NativeMethodInfoPtr_HasVolume_Public_Static_Boolean_GameObjectType_0;

		// Token: 0x04001862 RID: 6242
		private static readonly IntPtr NativeMethodInfoPtr_IsTypeBitSet_Public_Static_Boolean_Int32_GameObjectType_0;

		// Token: 0x04001863 RID: 6243
		private static readonly IntPtr NativeMethodInfoPtr_SetTypeBit_Public_Static_Int32_Int32_GameObjectType_0;

		// Token: 0x04001864 RID: 6244
		private static readonly IntPtr NativeMethodInfoPtr_ClearTypeBit_Public_Static_Int32_Int32_GameObjectType_0;
	}
}
