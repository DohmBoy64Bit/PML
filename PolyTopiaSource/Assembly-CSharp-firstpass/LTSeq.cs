using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000018 RID: 24
public class LTSeq : global::Il2CppSystem.Object
{
	// Token: 0x060004B1 RID: 1201 RVA: 0x00025AB0 File Offset: 0x00023CB0
	// Note: this type is marked as 'beforefieldinit'.
	static LTSeq()
	{
		Il2CppClassPointerStore<LTSeq>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LTSeq");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTSeq>.NativeClassPtr);
		LTSeq.NativeFieldInfoPtr_previous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, "previous");
		LTSeq.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, "current");
		LTSeq.NativeFieldInfoPtr_tween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, "tween");
		LTSeq.NativeFieldInfoPtr_totalDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, "totalDelay");
		LTSeq.NativeFieldInfoPtr_timeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, "timeScale");
		LTSeq.NativeFieldInfoPtr_debugIter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, "debugIter");
		LTSeq.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, "counter");
		LTSeq.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, "toggle");
		LTSeq.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, "_id");
		LTSeq.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100664144);
		LTSeq.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100664159);
		LTSeq.NativeMethodInfoPtr_reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100664145);
		LTSeq.NativeMethodInfoPtr_init_Public_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100664146);
		LTSeq.NativeMethodInfoPtr_addOn_Private_LTSeq_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100664147);
		LTSeq.NativeMethodInfoPtr_addPreviousDelays_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100664148);
		LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100664149);
		LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100664150);
		LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_Action_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100664151);
		LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_GameObject_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100664152);
		LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_GameObject_Action_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100664153);
		LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100664154);
		LTSeq.NativeMethodInfoPtr_insert_Public_LTSeq_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100664155);
		LTSeq.NativeMethodInfoPtr_setScale_Public_LTSeq_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100664156);
		LTSeq.NativeMethodInfoPtr_setScaleRecursive_Private_Void_LTSeq_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100664157);
		LTSeq.NativeMethodInfoPtr_reverse_Public_LTSeq_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTSeq>.NativeClassPtr, 100664158);
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00025CD4 File Offset: 0x00023ED4
	public unsafe int id
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x00025D10 File Offset: 0x00023F10
	[CallerCount(2275)]
	[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTSeq()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTSeq>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x00025D4C File Offset: 0x00023F4C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17953, RefRangeEnd = 17954, XrefRangeStart = 17951, XrefRangeEnd = 17953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x00025D80 File Offset: 0x00023F80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17954, XrefRangeEnd = 17957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void init(uint id, uint global_counter)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref global_counter;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_init_Public_Void_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x00025DCC File Offset: 0x00023FCC
	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 17963, RefRangeEnd = 17974, XrefRangeStart = 17957, XrefRangeEnd = 17963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTSeq addOn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_addOn_Private_LTSeq_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTSeq>(intPtr3) : null;
	}

	// Token: 0x060004B7 RID: 1207 RVA: 0x00025E0C File Offset: 0x0002400C
	[CallerCount(0)]
	public unsafe float addPreviousDelays()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_addPreviousDelays_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x00025E48 File Offset: 0x00024048
	[CallerCount(0)]
	public unsafe LTSeq append(float delay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTSeq>(intPtr3) : null;
		}
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x00025E94 File Offset: 0x00024094
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17974, XrefRangeEnd = 17982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTSeq append(Action callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTSeq>(intPtr3) : null;
		}
	}

	// Token: 0x060004BA RID: 1210 RVA: 0x00025EE4 File Offset: 0x000240E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17982, XrefRangeEnd = 17992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTSeq append(Action<global::Il2CppSystem.Object> callback, global::Il2CppSystem.Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_Action_1_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTSeq>(intPtr3) : null;
	}

	// Token: 0x060004BB RID: 1211 RVA: 0x00025F48 File Offset: 0x00024148
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17992, XrefRangeEnd = 18001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTSeq append(GameObject gameObject, Action callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_GameObject_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTSeq>(intPtr3) : null;
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x00025FAC File Offset: 0x000241AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18001, XrefRangeEnd = 18011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTSeq append(GameObject gameObject, Action<global::Il2CppSystem.Object> callback, global::Il2CppSystem.Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_GameObject_Action_1_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTSeq>(intPtr3) : null;
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x00026020 File Offset: 0x00024220
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18011, XrefRangeEnd = 18015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTSeq append(LTDescr tween)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tween);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_append_Public_LTSeq_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTSeq>(intPtr3) : null;
		}
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x00026070 File Offset: 0x00024270
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18015, XrefRangeEnd = 18019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTSeq insert(LTDescr tween)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tween);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_insert_Public_LTSeq_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTSeq>(intPtr3) : null;
		}
	}

	// Token: 0x060004BF RID: 1215 RVA: 0x000260C0 File Offset: 0x000242C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18019, XrefRangeEnd = 18022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTSeq setScale(float timeScale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref timeScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_setScale_Public_LTSeq_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTSeq>(intPtr3) : null;
		}
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x0002610C File Offset: 0x0002430C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 18022, RefRangeEnd = 18023, XrefRangeStart = 18022, XrefRangeEnd = 18022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setScaleRecursive(LTSeq seq, float timeScale, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(seq);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeScale;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_setScaleRecursive_Private_Void_LTSeq_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x0002616C File Offset: 0x0002436C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18023, XrefRangeEnd = 18024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTSeq reverse()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTSeq.NativeMethodInfoPtr_reverse_Public_LTSeq_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTSeq>(intPtr3) : null;
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x000032FC File Offset: 0x000014FC
	public LTSeq(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x060004C3 RID: 1219 RVA: 0x000261AC File Offset: 0x000243AC
	// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00003305 File Offset: 0x00001505
	public unsafe LTSeq previous
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_previous);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTSeq>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_previous), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x060004C5 RID: 1221 RVA: 0x000261DC File Offset: 0x000243DC
	// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00003324 File Offset: 0x00001524
	public unsafe LTSeq current
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_current);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTSeq>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0002620C File Offset: 0x0002440C
	// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00003343 File Offset: 0x00001543
	public unsafe LTDescr tween
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_tween);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTDescr>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_tween), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x060004C9 RID: 1225 RVA: 0x0002623C File Offset: 0x0002443C
	// (set) Token: 0x060004CA RID: 1226 RVA: 0x00003362 File Offset: 0x00001562
	public unsafe float totalDelay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_totalDelay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_totalDelay)) = value;
		}
	}

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x060004CB RID: 1227 RVA: 0x00026264 File Offset: 0x00024464
	// (set) Token: 0x060004CC RID: 1228 RVA: 0x0000337D File Offset: 0x0000157D
	public unsafe float timeScale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_timeScale);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_timeScale)) = value;
		}
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x060004CD RID: 1229 RVA: 0x0002628C File Offset: 0x0002448C
	// (set) Token: 0x060004CE RID: 1230 RVA: 0x00003398 File Offset: 0x00001598
	public unsafe int debugIter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_debugIter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_debugIter)) = value;
		}
	}

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x060004CF RID: 1231 RVA: 0x000262B4 File Offset: 0x000244B4
	// (set) Token: 0x060004D0 RID: 1232 RVA: 0x000033B3 File Offset: 0x000015B3
	public unsafe uint counter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_counter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_counter)) = value;
		}
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x060004D1 RID: 1233 RVA: 0x000262DC File Offset: 0x000244DC
	// (set) Token: 0x060004D2 RID: 1234 RVA: 0x000033CE File Offset: 0x000015CE
	public unsafe bool toggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_toggle);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr_toggle)) = value;
		}
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00026304 File Offset: 0x00024504
	// (set) Token: 0x060004D4 RID: 1236 RVA: 0x000033E9 File Offset: 0x000015E9
	public unsafe uint _id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr__id);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTSeq.NativeFieldInfoPtr__id)) = value;
		}
	}

	// Token: 0x04000433 RID: 1075
	private static readonly IntPtr NativeFieldInfoPtr_previous;

	// Token: 0x04000434 RID: 1076
	private static readonly IntPtr NativeFieldInfoPtr_current;

	// Token: 0x04000435 RID: 1077
	private static readonly IntPtr NativeFieldInfoPtr_tween;

	// Token: 0x04000436 RID: 1078
	private static readonly IntPtr NativeFieldInfoPtr_totalDelay;

	// Token: 0x04000437 RID: 1079
	private static readonly IntPtr NativeFieldInfoPtr_timeScale;

	// Token: 0x04000438 RID: 1080
	private static readonly IntPtr NativeFieldInfoPtr_debugIter;

	// Token: 0x04000439 RID: 1081
	private static readonly IntPtr NativeFieldInfoPtr_counter;

	// Token: 0x0400043A RID: 1082
	private static readonly IntPtr NativeFieldInfoPtr_toggle;

	// Token: 0x0400043B RID: 1083
	private static readonly IntPtr NativeFieldInfoPtr__id;

	// Token: 0x0400043C RID: 1084
	private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

	// Token: 0x0400043D RID: 1085
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0400043E RID: 1086
	private static readonly IntPtr NativeMethodInfoPtr_reset_Public_Void_0;

	// Token: 0x0400043F RID: 1087
	private static readonly IntPtr NativeMethodInfoPtr_init_Public_Void_UInt32_UInt32_0;

	// Token: 0x04000440 RID: 1088
	private static readonly IntPtr NativeMethodInfoPtr_addOn_Private_LTSeq_0;

	// Token: 0x04000441 RID: 1089
	private static readonly IntPtr NativeMethodInfoPtr_addPreviousDelays_Private_Single_0;

	// Token: 0x04000442 RID: 1090
	private static readonly IntPtr NativeMethodInfoPtr_append_Public_LTSeq_Single_0;

	// Token: 0x04000443 RID: 1091
	private static readonly IntPtr NativeMethodInfoPtr_append_Public_LTSeq_Action_0;

	// Token: 0x04000444 RID: 1092
	private static readonly IntPtr NativeMethodInfoPtr_append_Public_LTSeq_Action_1_Object_Object_0;

	// Token: 0x04000445 RID: 1093
	private static readonly IntPtr NativeMethodInfoPtr_append_Public_LTSeq_GameObject_Action_0;

	// Token: 0x04000446 RID: 1094
	private static readonly IntPtr NativeMethodInfoPtr_append_Public_LTSeq_GameObject_Action_1_Object_Object_0;

	// Token: 0x04000447 RID: 1095
	private static readonly IntPtr NativeMethodInfoPtr_append_Public_LTSeq_LTDescr_0;

	// Token: 0x04000448 RID: 1096
	private static readonly IntPtr NativeMethodInfoPtr_insert_Public_LTSeq_LTDescr_0;

	// Token: 0x04000449 RID: 1097
	private static readonly IntPtr NativeMethodInfoPtr_setScale_Public_LTSeq_Single_0;

	// Token: 0x0400044A RID: 1098
	private static readonly IntPtr NativeMethodInfoPtr_setScaleRecursive_Private_Void_LTSeq_Single_Int32_0;

	// Token: 0x0400044B RID: 1099
	private static readonly IntPtr NativeMethodInfoPtr_reverse_Public_LTSeq_0;
}
