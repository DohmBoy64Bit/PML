using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002FF RID: 767
	public class UIFieldProxy : InstanceProxy
	{
		// Token: 0x060042B5 RID: 17077 RVA: 0x0012B960 File Offset: 0x00129B60
		// Note: this type is marked as 'beforefieldinit'.
		static UIFieldProxy()
		{
			Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "UIFieldProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr);
			UIFieldProxy.NativeFieldInfoPtr_uiField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, "uiField");
			UIFieldProxy.NativeMethodInfoPtr_get_MouseUp_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, 100673838);
			UIFieldProxy.NativeMethodInfoPtr_get_MouseDown_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, 100673839);
			UIFieldProxy.NativeMethodInfoPtr_get_PositionOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, 100673840);
			UIFieldProxy.NativeMethodInfoPtr_set_PositionOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, 100673841);
			UIFieldProxy.NativeMethodInfoPtr_get_PositionRelative_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, 100673842);
			UIFieldProxy.NativeMethodInfoPtr_set_PositionRelative_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, 100673843);
			UIFieldProxy.NativeMethodInfoPtr_get_Rotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, 100673844);
			UIFieldProxy.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, 100673845);
			UIFieldProxy.NativeMethodInfoPtr_get_SizeOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, 100673846);
			UIFieldProxy.NativeMethodInfoPtr_set_SizeOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, 100673847);
			UIFieldProxy.NativeMethodInfoPtr_get_SizeRelative_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, 100673848);
			UIFieldProxy.NativeMethodInfoPtr_set_SizeRelative_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, 100673849);
			UIFieldProxy.NativeMethodInfoPtr_get_PivotPoint_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, 100673850);
			UIFieldProxy.NativeMethodInfoPtr_set_PivotPoint_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, 100673851);
			UIFieldProxy.NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, 100673852);
			UIFieldProxy.NativeMethodInfoPtr_set_Visible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, 100673853);
			UIFieldProxy.NativeMethodInfoPtr_get_ClipDescendants_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, 100673854);
			UIFieldProxy.NativeMethodInfoPtr_set_ClipDescendants_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, 100673855);
			UIFieldProxy.NativeMethodInfoPtr__ctor_Public_Void_UIField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr, 100673837);
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x060042B6 RID: 17078 RVA: 0x0012BB20 File Offset: 0x00129D20
		public unsafe LuaEvent MouseUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFieldProxy.NativeMethodInfoPtr_get_MouseUp_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x060042B7 RID: 17079 RVA: 0x0012BB60 File Offset: 0x00129D60
		public unsafe LuaEvent MouseDown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFieldProxy.NativeMethodInfoPtr_get_MouseDown_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x060042B8 RID: 17080 RVA: 0x0012BBA0 File Offset: 0x00129DA0
		// (set) Token: 0x060042B9 RID: 17081 RVA: 0x0012BBE0 File Offset: 0x00129DE0
		public unsafe Vector2 PositionOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFieldProxy.NativeMethodInfoPtr_get_PositionOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129076, XrefRangeEnd = 129078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFieldProxy.NativeMethodInfoPtr_set_PositionOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x060042BA RID: 17082 RVA: 0x0012BC24 File Offset: 0x00129E24
		// (set) Token: 0x060042BB RID: 17083 RVA: 0x0012BC64 File Offset: 0x00129E64
		public unsafe Vector2 PositionRelative
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFieldProxy.NativeMethodInfoPtr_get_PositionRelative_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129078, XrefRangeEnd = 129080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFieldProxy.NativeMethodInfoPtr_set_PositionRelative_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x060042BC RID: 17084 RVA: 0x0012BCA8 File Offset: 0x00129EA8
		// (set) Token: 0x060042BD RID: 17085 RVA: 0x0012BCE4 File Offset: 0x00129EE4
		public unsafe float Rotation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129080, XrefRangeEnd = 129082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFieldProxy.NativeMethodInfoPtr_get_Rotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129082, XrefRangeEnd = 129084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFieldProxy.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x060042BE RID: 17086 RVA: 0x0012BD24 File Offset: 0x00129F24
		// (set) Token: 0x060042BF RID: 17087 RVA: 0x0012BD64 File Offset: 0x00129F64
		public unsafe Vector2 SizeOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFieldProxy.NativeMethodInfoPtr_get_SizeOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129084, XrefRangeEnd = 129086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFieldProxy.NativeMethodInfoPtr_set_SizeOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x060042C0 RID: 17088 RVA: 0x0012BDA8 File Offset: 0x00129FA8
		// (set) Token: 0x060042C1 RID: 17089 RVA: 0x0012BDE8 File Offset: 0x00129FE8
		public unsafe Vector2 SizeRelative
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFieldProxy.NativeMethodInfoPtr_get_SizeRelative_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129086, XrefRangeEnd = 129088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFieldProxy.NativeMethodInfoPtr_set_SizeRelative_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x060042C2 RID: 17090 RVA: 0x0012BE2C File Offset: 0x0012A02C
		// (set) Token: 0x060042C3 RID: 17091 RVA: 0x0012BE6C File Offset: 0x0012A06C
		public unsafe Vector2 PivotPoint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129088, XrefRangeEnd = 129090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFieldProxy.NativeMethodInfoPtr_get_PivotPoint_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129090, XrefRangeEnd = 129092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFieldProxy.NativeMethodInfoPtr_set_PivotPoint_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x060042C4 RID: 17092 RVA: 0x0012BEB0 File Offset: 0x0012A0B0
		// (set) Token: 0x060042C5 RID: 17093 RVA: 0x0012BEEC File Offset: 0x0012A0EC
		public unsafe bool Visible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFieldProxy.NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129092, XrefRangeEnd = 129094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFieldProxy.NativeMethodInfoPtr_set_Visible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x060042C6 RID: 17094 RVA: 0x0012BF2C File Offset: 0x0012A12C
		// (set) Token: 0x060042C7 RID: 17095 RVA: 0x0012BF68 File Offset: 0x0012A168
		public unsafe bool ClipDescendants
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFieldProxy.NativeMethodInfoPtr_get_ClipDescendants_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129094, XrefRangeEnd = 129096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFieldProxy.NativeMethodInfoPtr_set_ClipDescendants_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x0012BFA8 File Offset: 0x0012A1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIFieldProxy(UIField target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIFieldProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFieldProxy.NativeMethodInfoPtr__ctor_Public_Void_UIField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x00018C19 File Offset: 0x00016E19
		public UIFieldProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x060042CA RID: 17098 RVA: 0x0012BFF4 File Offset: 0x0012A1F4
		// (set) Token: 0x060042CB RID: 17099 RVA: 0x00018C22 File Offset: 0x00016E22
		public unsafe UIField uiField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFieldProxy.NativeFieldInfoPtr_uiField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFieldProxy.NativeFieldInfoPtr_uiField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033F7 RID: 13303
		private static readonly IntPtr NativeFieldInfoPtr_uiField;

		// Token: 0x040033F8 RID: 13304
		private static readonly IntPtr NativeMethodInfoPtr_get_MouseUp_Public_get_LuaEvent_0;

		// Token: 0x040033F9 RID: 13305
		private static readonly IntPtr NativeMethodInfoPtr_get_MouseDown_Public_get_LuaEvent_0;

		// Token: 0x040033FA RID: 13306
		private static readonly IntPtr NativeMethodInfoPtr_get_PositionOffset_Public_get_Vector2_0;

		// Token: 0x040033FB RID: 13307
		private static readonly IntPtr NativeMethodInfoPtr_set_PositionOffset_Public_set_Void_Vector2_0;

		// Token: 0x040033FC RID: 13308
		private static readonly IntPtr NativeMethodInfoPtr_get_PositionRelative_Public_get_Vector2_0;

		// Token: 0x040033FD RID: 13309
		private static readonly IntPtr NativeMethodInfoPtr_set_PositionRelative_Public_set_Void_Vector2_0;

		// Token: 0x040033FE RID: 13310
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Single_0;

		// Token: 0x040033FF RID: 13311
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Single_0;

		// Token: 0x04003400 RID: 13312
		private static readonly IntPtr NativeMethodInfoPtr_get_SizeOffset_Public_get_Vector2_0;

		// Token: 0x04003401 RID: 13313
		private static readonly IntPtr NativeMethodInfoPtr_set_SizeOffset_Public_set_Void_Vector2_0;

		// Token: 0x04003402 RID: 13314
		private static readonly IntPtr NativeMethodInfoPtr_get_SizeRelative_Public_get_Vector2_0;

		// Token: 0x04003403 RID: 13315
		private static readonly IntPtr NativeMethodInfoPtr_set_SizeRelative_Public_set_Void_Vector2_0;

		// Token: 0x04003404 RID: 13316
		private static readonly IntPtr NativeMethodInfoPtr_get_PivotPoint_Public_get_Vector2_0;

		// Token: 0x04003405 RID: 13317
		private static readonly IntPtr NativeMethodInfoPtr_set_PivotPoint_Public_set_Void_Vector2_0;

		// Token: 0x04003406 RID: 13318
		private static readonly IntPtr NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0;

		// Token: 0x04003407 RID: 13319
		private static readonly IntPtr NativeMethodInfoPtr_set_Visible_Public_set_Void_Boolean_0;

		// Token: 0x04003408 RID: 13320
		private static readonly IntPtr NativeMethodInfoPtr_get_ClipDescendants_Public_get_Boolean_0;

		// Token: 0x04003409 RID: 13321
		private static readonly IntPtr NativeMethodInfoPtr_set_ClipDescendants_Public_set_Void_Boolean_0;

		// Token: 0x0400340A RID: 13322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIField_0;
	}
}
