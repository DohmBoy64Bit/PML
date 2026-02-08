using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000013 RID: 19
public class LTEvent : Object
{
	// Token: 0x06000222 RID: 546 RVA: 0x00019C08 File Offset: 0x00017E08
	// Note: this type is marked as 'beforefieldinit'.
	static LTEvent()
	{
		Il2CppClassPointerStore<LTEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LTEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTEvent>.NativeClassPtr);
		LTEvent.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTEvent>.NativeClassPtr, "id");
		LTEvent.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTEvent>.NativeClassPtr, "data");
		LTEvent.NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTEvent>.NativeClassPtr, 100663658);
	}

	// Token: 0x06000223 RID: 547 RVA: 0x00019C74 File Offset: 0x00017E74
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 13734, RefRangeEnd = 13735, XrefRangeStart = 13725, XrefRangeEnd = 13734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTEvent(int id, Object data)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTEvent>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LTEvent.NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000224 RID: 548 RVA: 0x000029BC File Offset: 0x00000BBC
	public LTEvent(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x06000225 RID: 549 RVA: 0x00019CD0 File Offset: 0x00017ED0
	// (set) Token: 0x06000226 RID: 550 RVA: 0x000029C5 File Offset: 0x00000BC5
	public unsafe int id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTEvent.NativeFieldInfoPtr_id);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTEvent.NativeFieldInfoPtr_id)) = value;
		}
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x06000227 RID: 551 RVA: 0x00019CF8 File Offset: 0x00017EF8
	// (set) Token: 0x06000228 RID: 552 RVA: 0x000029E0 File Offset: 0x00000BE0
	public unsafe Object data
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTEvent.NativeFieldInfoPtr_data);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LTEvent.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000204 RID: 516
	private static readonly IntPtr NativeFieldInfoPtr_id;

	// Token: 0x04000205 RID: 517
	private static readonly IntPtr NativeFieldInfoPtr_data;

	// Token: 0x04000206 RID: 518
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0;
}
