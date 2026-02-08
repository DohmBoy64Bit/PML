using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace RLD
{
	// Token: 0x02000198 RID: 408
	public class RTHoveredPrefabNameLabel : MonoBehaviour
	{
		// Token: 0x06001F78 RID: 8056 RVA: 0x0009EC7C File Offset: 0x0009CE7C
		// Note: this type is marked as 'beforefieldinit'.
		static RTHoveredPrefabNameLabel()
		{
			Il2CppClassPointerStore<RTHoveredPrefabNameLabel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTHoveredPrefabNameLabel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTHoveredPrefabNameLabel>.NativeClassPtr);
			RTHoveredPrefabNameLabel.NativeFieldInfoPtr__label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHoveredPrefabNameLabel>.NativeClassPtr, "_label");
			RTHoveredPrefabNameLabel.NativeMethodInfoPtr_get_PrefabName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHoveredPrefabNameLabel>.NativeClassPtr, 100668088);
			RTHoveredPrefabNameLabel.NativeMethodInfoPtr_set_PrefabName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHoveredPrefabNameLabel>.NativeClassPtr, 100668089);
			RTHoveredPrefabNameLabel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHoveredPrefabNameLabel>.NativeClassPtr, 100668091);
			RTHoveredPrefabNameLabel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHoveredPrefabNameLabel>.NativeClassPtr, 100668090);
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x0009ED10 File Offset: 0x0009CF10
		// (set) Token: 0x06001F7A RID: 8058 RVA: 0x0009ED48 File Offset: 0x0009CF48
		public unsafe string PrefabName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83586, XrefRangeEnd = 83587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHoveredPrefabNameLabel.NativeMethodInfoPtr_get_PrefabName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHoveredPrefabNameLabel.NativeMethodInfoPtr_set_PrefabName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x0009ED8C File Offset: 0x0009CF8C
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTHoveredPrefabNameLabel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTHoveredPrefabNameLabel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHoveredPrefabNameLabel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x0009EDC8 File Offset: 0x0009CFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83587, XrefRangeEnd = 83591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHoveredPrefabNameLabel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x0000CCF4 File Offset: 0x0000AEF4
		public RTHoveredPrefabNameLabel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06001F7E RID: 8062 RVA: 0x0009EDFC File Offset: 0x0009CFFC
		// (set) Token: 0x06001F7F RID: 8063 RVA: 0x0000CCFD File Offset: 0x0000AEFD
		public unsafe Text _label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHoveredPrefabNameLabel.NativeFieldInfoPtr__label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHoveredPrefabNameLabel.NativeFieldInfoPtr__label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018AD RID: 6317
		private static readonly IntPtr NativeFieldInfoPtr__label;

		// Token: 0x040018AE RID: 6318
		private static readonly IntPtr NativeMethodInfoPtr_get_PrefabName_Public_get_String_0;

		// Token: 0x040018AF RID: 6319
		private static readonly IntPtr NativeMethodInfoPtr_set_PrefabName_Public_set_Void_String_0;

		// Token: 0x040018B0 RID: 6320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040018B1 RID: 6321
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
	}
}
