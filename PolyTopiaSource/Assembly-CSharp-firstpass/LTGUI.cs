using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000014 RID: 20
public class LTGUI : global::Il2CppSystem.Object
{
	// Token: 0x06000229 RID: 553 RVA: 0x00019D28 File Offset: 0x00017F28
	// Note: this type is marked as 'beforefieldinit'.
	static LTGUI()
	{
		Il2CppClassPointerStore<LTGUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LTGUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTGUI>.NativeClassPtr);
		LTGUI.NativeFieldInfoPtr_RECT_LEVELS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "RECT_LEVELS");
		LTGUI.NativeFieldInfoPtr_RECTS_PER_LEVEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "RECTS_PER_LEVEL");
		LTGUI.NativeFieldInfoPtr_BUTTONS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "BUTTONS_MAX");
		LTGUI.NativeFieldInfoPtr_levels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "levels");
		LTGUI.NativeFieldInfoPtr_levelDepths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "levelDepths");
		LTGUI.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "buttons");
		LTGUI.NativeFieldInfoPtr_buttonLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "buttonLevels");
		LTGUI.NativeFieldInfoPtr_buttonLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "buttonLastFrame");
		LTGUI.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "r");
		LTGUI.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "color");
		LTGUI.NativeFieldInfoPtr_isGUIEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "isGUIEnabled");
		LTGUI.NativeFieldInfoPtr_global_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, "global_counter");
		LTGUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100663675);
		LTGUI.NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100663659);
		LTGUI.NativeMethodInfoPtr_initRectCheck_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100663660);
		LTGUI.NativeMethodInfoPtr_reset_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100663661);
		LTGUI.NativeMethodInfoPtr_update_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100663662);
		LTGUI.NativeMethodInfoPtr_checkOnScreen_Public_Static_Boolean_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100663663);
		LTGUI.NativeMethodInfoPtr_destroy_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100663664);
		LTGUI.NativeMethodInfoPtr_destroyAll_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100663665);
		LTGUI.NativeMethodInfoPtr_label_Public_Static_LTRect_Rect_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100663666);
		LTGUI.NativeMethodInfoPtr_label_Public_Static_LTRect_LTRect_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100663667);
		LTGUI.NativeMethodInfoPtr_texture_Public_Static_LTRect_Rect_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100663668);
		LTGUI.NativeMethodInfoPtr_texture_Public_Static_LTRect_LTRect_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100663669);
		LTGUI.NativeMethodInfoPtr_element_Public_Static_LTRect_LTRect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100663670);
		LTGUI.NativeMethodInfoPtr_hasNoOverlap_Public_Static_Boolean_Rect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100663671);
		LTGUI.NativeMethodInfoPtr_pressedWithinRect_Public_Static_Boolean_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100663672);
		LTGUI.NativeMethodInfoPtr_checkWithinRect_Public_Static_Boolean_Vector2_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100663673);
		LTGUI.NativeMethodInfoPtr_firstTouch_Public_Static_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTGUI>.NativeClassPtr, 100663674);
	}

	// Token: 0x0600022A RID: 554 RVA: 0x00019F9C File Offset: 0x0001819C
	[CallerCount(2275)]
	[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTGUI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTGUI>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600022B RID: 555 RVA: 0x00019FD8 File Offset: 0x000181D8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 13754, RefRangeEnd = 13756, XrefRangeStart = 13735, XrefRangeEnd = 13754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_init_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600022C RID: 556 RVA: 0x0001A000 File Offset: 0x00018200
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13756, XrefRangeEnd = 13787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void initRectCheck()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_initRectCheck_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600022D RID: 557 RVA: 0x0001A028 File Offset: 0x00018228
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13787, XrefRangeEnd = 13806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void reset()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_reset_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600022E RID: 558 RVA: 0x0001A050 File Offset: 0x00018250
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13806, XrefRangeEnd = 13943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void update(int updateLevel)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref updateLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_update_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600022F RID: 559 RVA: 0x0001A084 File Offset: 0x00018284
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13943, XrefRangeEnd = 13948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool checkOnScreen(Rect rect)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_checkOnScreen_Public_Static_Boolean_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000230 RID: 560 RVA: 0x0001A0C8 File Offset: 0x000182C8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 13959, RefRangeEnd = 13961, XrefRangeStart = 13948, XrefRangeEnd = 13959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void destroy(int id)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_destroy_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000231 RID: 561 RVA: 0x0001A0FC File Offset: 0x000182FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13961, XrefRangeEnd = 13972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void destroyAll(int depth)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_destroyAll_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000232 RID: 562 RVA: 0x0001A130 File Offset: 0x00018330
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13972, XrefRangeEnd = 13986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTRect label(Rect rect, string label, int depth)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_label_Public_Static_LTRect_Rect_String_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTRect>(intPtr3) : null;
	}

	// Token: 0x06000233 RID: 563 RVA: 0x0001A194 File Offset: 0x00018394
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13986, XrefRangeEnd = 13992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTRect label(LTRect rect, string label, int depth)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_label_Public_Static_LTRect_LTRect_String_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTRect>(intPtr3) : null;
	}

	// Token: 0x06000234 RID: 564 RVA: 0x0001A1F8 File Offset: 0x000183F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13992, XrefRangeEnd = 14006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTRect texture(Rect rect, Texture texture, int depth)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_texture_Public_Static_LTRect_Rect_Texture_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTRect>(intPtr3) : null;
	}

	// Token: 0x06000235 RID: 565 RVA: 0x0001A25C File Offset: 0x0001845C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14006, XrefRangeEnd = 14012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_texture_Public_Static_LTRect_LTRect_Texture_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTRect>(intPtr3) : null;
	}

	// Token: 0x06000236 RID: 566 RVA: 0x0001A2C0 File Offset: 0x000184C0
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 14046, RefRangeEnd = 14050, XrefRangeStart = 14012, XrefRangeEnd = 14046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTRect element(LTRect rect, int depth)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_element_Public_Static_LTRect_LTRect_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<LTRect>(intPtr3) : null;
	}

	// Token: 0x06000237 RID: 567 RVA: 0x0001A314 File Offset: 0x00018514
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14050, XrefRangeEnd = 14112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool hasNoOverlap(Rect rect, int depth)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_hasNoOverlap_Public_Static_Boolean_Rect_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000238 RID: 568 RVA: 0x0001A364 File Offset: 0x00018564
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14132, RefRangeEnd = 14133, XrefRangeStart = 14112, XrefRangeEnd = 14132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool pressedWithinRect(Rect rect)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_pressedWithinRect_Public_Static_Boolean_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000239 RID: 569 RVA: 0x0001A3A8 File Offset: 0x000185A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14133, XrefRangeEnd = 14143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vec2);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rect);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_checkWithinRect_Public_Static_Boolean_Vector2_Rect_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600023A RID: 570 RVA: 0x0001A3FC File Offset: 0x000185FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14143, XrefRangeEnd = 14145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 firstTouch()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTGUI.NativeMethodInfoPtr_firstTouch_Public_Static_Vector2_0, 0, (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
	}

	// Token: 0x0600023B RID: 571 RVA: 0x000029FF File Offset: 0x00000BFF
	public LTGUI(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x0600023C RID: 572 RVA: 0x0001A430 File Offset: 0x00018630
	// (set) Token: 0x0600023D RID: 573 RVA: 0x00002A08 File Offset: 0x00000C08
	public unsafe static int RECT_LEVELS
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_RECT_LEVELS, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_RECT_LEVELS, (void*)(&value));
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x0600023E RID: 574 RVA: 0x0001A44C File Offset: 0x0001864C
	// (set) Token: 0x0600023F RID: 575 RVA: 0x00002A16 File Offset: 0x00000C16
	public unsafe static int RECTS_PER_LEVEL
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_RECTS_PER_LEVEL, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_RECTS_PER_LEVEL, (void*)(&value));
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x06000240 RID: 576 RVA: 0x0001A468 File Offset: 0x00018668
	// (set) Token: 0x06000241 RID: 577 RVA: 0x00002A24 File Offset: 0x00000C24
	public unsafe static int BUTTONS_MAX
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_BUTTONS_MAX, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_BUTTONS_MAX, (void*)(&value));
		}
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x06000242 RID: 578 RVA: 0x0001A484 File Offset: 0x00018684
	// (set) Token: 0x06000243 RID: 579 RVA: 0x00002A32 File Offset: 0x00000C32
	public unsafe static Il2CppReferenceArray<LTRect> levels
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_levels, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LTRect>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_levels, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x06000244 RID: 580 RVA: 0x0001A4AC File Offset: 0x000186AC
	// (set) Token: 0x06000245 RID: 581 RVA: 0x00002A44 File Offset: 0x00000C44
	public unsafe static Il2CppStructArray<int> levelDepths
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_levelDepths, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_levelDepths, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x06000246 RID: 582 RVA: 0x0001A4D4 File Offset: 0x000186D4
	// (set) Token: 0x06000247 RID: 583 RVA: 0x00002A56 File Offset: 0x00000C56
	public unsafe static Il2CppStructArray<Rect> buttons
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_buttons, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Rect>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_buttons, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x06000248 RID: 584 RVA: 0x0001A4FC File Offset: 0x000186FC
	// (set) Token: 0x06000249 RID: 585 RVA: 0x00002A68 File Offset: 0x00000C68
	public unsafe static Il2CppStructArray<int> buttonLevels
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_buttonLevels, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_buttonLevels, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x0600024A RID: 586 RVA: 0x0001A524 File Offset: 0x00018724
	// (set) Token: 0x0600024B RID: 587 RVA: 0x00002A7A File Offset: 0x00000C7A
	public unsafe static Il2CppStructArray<int> buttonLastFrame
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_buttonLastFrame, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_buttonLastFrame, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x0600024C RID: 588 RVA: 0x0001A54C File Offset: 0x0001874C
	// (set) Token: 0x0600024D RID: 589 RVA: 0x00002A8C File Offset: 0x00000C8C
	public unsafe static LTRect r
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_r, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LTRect>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_r, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x0600024E RID: 590 RVA: 0x0001A574 File Offset: 0x00018774
	// (set) Token: 0x0600024F RID: 591 RVA: 0x00002A9E File Offset: 0x00000C9E
	public unsafe static Color color
	{
		get
		{
			Color color;
			IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_color, (void*)(&color));
			return color;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_color, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x06000250 RID: 592 RVA: 0x0001A590 File Offset: 0x00018790
	// (set) Token: 0x06000251 RID: 593 RVA: 0x00002AB0 File Offset: 0x00000CB0
	public unsafe static bool isGUIEnabled
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_isGUIEnabled, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_isGUIEnabled, (void*)(&value));
		}
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x06000252 RID: 594 RVA: 0x0001A5AC File Offset: 0x000187AC
	// (set) Token: 0x06000253 RID: 595 RVA: 0x00002ABE File Offset: 0x00000CBE
	public unsafe static int global_counter
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(LTGUI.NativeFieldInfoPtr_global_counter, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LTGUI.NativeFieldInfoPtr_global_counter, (void*)(&value));
		}
	}

	// Token: 0x04000207 RID: 519
	private static readonly IntPtr NativeFieldInfoPtr_RECT_LEVELS;

	// Token: 0x04000208 RID: 520
	private static readonly IntPtr NativeFieldInfoPtr_RECTS_PER_LEVEL;

	// Token: 0x04000209 RID: 521
	private static readonly IntPtr NativeFieldInfoPtr_BUTTONS_MAX;

	// Token: 0x0400020A RID: 522
	private static readonly IntPtr NativeFieldInfoPtr_levels;

	// Token: 0x0400020B RID: 523
	private static readonly IntPtr NativeFieldInfoPtr_levelDepths;

	// Token: 0x0400020C RID: 524
	private static readonly IntPtr NativeFieldInfoPtr_buttons;

	// Token: 0x0400020D RID: 525
	private static readonly IntPtr NativeFieldInfoPtr_buttonLevels;

	// Token: 0x0400020E RID: 526
	private static readonly IntPtr NativeFieldInfoPtr_buttonLastFrame;

	// Token: 0x0400020F RID: 527
	private static readonly IntPtr NativeFieldInfoPtr_r;

	// Token: 0x04000210 RID: 528
	private static readonly IntPtr NativeFieldInfoPtr_color;

	// Token: 0x04000211 RID: 529
	private static readonly IntPtr NativeFieldInfoPtr_isGUIEnabled;

	// Token: 0x04000212 RID: 530
	private static readonly IntPtr NativeFieldInfoPtr_global_counter;

	// Token: 0x04000213 RID: 531
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000214 RID: 532
	private static readonly IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;

	// Token: 0x04000215 RID: 533
	private static readonly IntPtr NativeMethodInfoPtr_initRectCheck_Public_Static_Void_0;

	// Token: 0x04000216 RID: 534
	private static readonly IntPtr NativeMethodInfoPtr_reset_Public_Static_Void_0;

	// Token: 0x04000217 RID: 535
	private static readonly IntPtr NativeMethodInfoPtr_update_Public_Static_Void_Int32_0;

	// Token: 0x04000218 RID: 536
	private static readonly IntPtr NativeMethodInfoPtr_checkOnScreen_Public_Static_Boolean_Rect_0;

	// Token: 0x04000219 RID: 537
	private static readonly IntPtr NativeMethodInfoPtr_destroy_Public_Static_Void_Int32_0;

	// Token: 0x0400021A RID: 538
	private static readonly IntPtr NativeMethodInfoPtr_destroyAll_Public_Static_Void_Int32_0;

	// Token: 0x0400021B RID: 539
	private static readonly IntPtr NativeMethodInfoPtr_label_Public_Static_LTRect_Rect_String_Int32_0;

	// Token: 0x0400021C RID: 540
	private static readonly IntPtr NativeMethodInfoPtr_label_Public_Static_LTRect_LTRect_String_Int32_0;

	// Token: 0x0400021D RID: 541
	private static readonly IntPtr NativeMethodInfoPtr_texture_Public_Static_LTRect_Rect_Texture_Int32_0;

	// Token: 0x0400021E RID: 542
	private static readonly IntPtr NativeMethodInfoPtr_texture_Public_Static_LTRect_LTRect_Texture_Int32_0;

	// Token: 0x0400021F RID: 543
	private static readonly IntPtr NativeMethodInfoPtr_element_Public_Static_LTRect_LTRect_Int32_0;

	// Token: 0x04000220 RID: 544
	private static readonly IntPtr NativeMethodInfoPtr_hasNoOverlap_Public_Static_Boolean_Rect_Int32_0;

	// Token: 0x04000221 RID: 545
	private static readonly IntPtr NativeMethodInfoPtr_pressedWithinRect_Public_Static_Boolean_Rect_0;

	// Token: 0x04000222 RID: 546
	private static readonly IntPtr NativeMethodInfoPtr_checkWithinRect_Public_Static_Boolean_Vector2_Rect_0;

	// Token: 0x04000223 RID: 547
	private static readonly IntPtr NativeMethodInfoPtr_firstTouch_Public_Static_Vector2_0;

	// Token: 0x0200016D RID: 365
	public enum Element_Type
	{
		// Token: 0x040014A6 RID: 5286
		Texture,
		// Token: 0x040014A7 RID: 5287
		Label
	}
}
