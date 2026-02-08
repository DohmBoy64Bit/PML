using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000166 RID: 358
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Object
{
	// Token: 0x06001882 RID: 6274 RVA: 0x0007B29C File Offset: 0x0007949C
	// Note: this type is marked as 'beforefieldinit'.
	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "<PrivateImplementationDetails>");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr__14752532C1FE243542B7593B4B49247E2FFA19F0F95505944743F608FC486F5D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "14752532C1FE243542B7593B4B49247E2FFA19F0F95505944743F608FC486F5D");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr__9C6D3221B6A2F3573A0F50BB8934E208DD38404B04EE793DD29202D37AD041A9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "9C6D3221B6A2F3573A0F50BB8934E208DD38404B04EE793DD29202D37AD041A9");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr_B685D0868D68E3411CA223F3B840AAA93F3C178B2D04DA1478FA9D73F443EB57 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "B685D0868D68E3411CA223F3B840AAA93F3C178B2D04DA1478FA9D73F443EB57");
		global::_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, 100668557);
	}

	// Token: 0x06001883 RID: 6275 RVA: 0x0007B314 File Offset: 0x00079514
	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 55587, RefRangeEnd = 55612, XrefRangeStart = 55585, XrefRangeEnd = 55587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ComputeStringHash(string s)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001884 RID: 6276 RVA: 0x00009A88 File Offset: 0x00007C88
	public _PrivateImplementationDetails_(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000592 RID: 1426
	// (get) Token: 0x06001885 RID: 6277 RVA: 0x0007B358 File Offset: 0x00079558
	// (set) Token: 0x06001886 RID: 6278 RVA: 0x00009A91 File Offset: 0x00007C91
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed2 _14752532C1FE243542B7593B4B49247E2FFA19F0F95505944743F608FC486F5D
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed2 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__14752532C1FE243542B7593B4B49247E2FFA19F0F95505944743F608FC486F5D, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__14752532C1FE243542B7593B4B49247E2FFA19F0F95505944743F608FC486F5D, (void*)(&value));
		}
	}

	// Token: 0x17000593 RID: 1427
	// (get) Token: 0x06001887 RID: 6279 RVA: 0x0007B374 File Offset: 0x00079574
	// (set) Token: 0x06001888 RID: 6280 RVA: 0x00009A9F File Offset: 0x00007C9F
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 _9C6D3221B6A2F3573A0F50BB8934E208DD38404B04EE793DD29202D37AD041A9
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__9C6D3221B6A2F3573A0F50BB8934E208DD38404B04EE793DD29202D37AD041A9, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__9C6D3221B6A2F3573A0F50BB8934E208DD38404B04EE793DD29202D37AD041A9, (void*)(&value));
		}
	}

	// Token: 0x17000594 RID: 1428
	// (get) Token: 0x06001889 RID: 6281 RVA: 0x0007B390 File Offset: 0x00079590
	// (set) Token: 0x0600188A RID: 6282 RVA: 0x00009AAD File Offset: 0x00007CAD
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 B685D0868D68E3411CA223F3B840AAA93F3C178B2D04DA1478FA9D73F443EB57
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_B685D0868D68E3411CA223F3B840AAA93F3C178B2D04DA1478FA9D73F443EB57, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_B685D0868D68E3411CA223F3B840AAA93F3C178B2D04DA1478FA9D73F443EB57, (void*)(&value));
		}
	}

	// Token: 0x04001456 RID: 5206
	private static readonly IntPtr NativeFieldInfoPtr__14752532C1FE243542B7593B4B49247E2FFA19F0F95505944743F608FC486F5D;

	// Token: 0x04001457 RID: 5207
	private static readonly IntPtr NativeFieldInfoPtr__9C6D3221B6A2F3573A0F50BB8934E208DD38404B04EE793DD29202D37AD041A9;

	// Token: 0x04001458 RID: 5208
	private static readonly IntPtr NativeFieldInfoPtr_B685D0868D68E3411CA223F3B840AAA93F3C178B2D04DA1478FA9D73F443EB57;

	// Token: 0x04001459 RID: 5209
	private static readonly IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;

	// Token: 0x0200024C RID: 588
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=128")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed0
	{
		// Token: 0x06002175 RID: 8565 RVA: 0x0000DF7E File Offset: 0x0000C17E
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed0()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=128");
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x0000DF94 File Offset: 0x0000C194
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr, ref this));
		}
	}

	// Token: 0x0200024D RID: 589
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=17658")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed1
	{
		// Token: 0x06002177 RID: 8567 RVA: 0x0000DFA6 File Offset: 0x0000C1A6
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed1()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=17658");
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x0000DFBC File Offset: 0x0000C1BC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr, ref this));
		}
	}

	// Token: 0x0200024E RID: 590
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=22190")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed2
	{
		// Token: 0x06002179 RID: 8569 RVA: 0x0000DFCE File Offset: 0x0000C1CE
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed2()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=22190");
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x0000DFE4 File Offset: 0x0000C1E4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed2>.NativeClassPtr, ref this));
		}
	}
}
