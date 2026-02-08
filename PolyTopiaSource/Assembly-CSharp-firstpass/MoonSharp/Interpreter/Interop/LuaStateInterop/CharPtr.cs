using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Interop.LuaStateInterop
{
	// Token: 0x020000C9 RID: 201
	public class CharPtr : Object
	{
		// Token: 0x06000F49 RID: 3913 RVA: 0x000531D0 File Offset: 0x000513D0
		// Note: this type is marked as 'beforefieldinit'.
		static CharPtr()
		{
			Il2CppClassPointerStore<CharPtr>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop.LuaStateInterop", "CharPtr");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharPtr>.NativeClassPtr);
			CharPtr.NativeFieldInfoPtr_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, "chars");
			CharPtr.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, "index");
			CharPtr.NativeMethodInfoPtr_get_Item_Public_get_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666042);
			CharPtr.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666043);
			CharPtr.NativeMethodInfoPtr_get_Item_Public_get_Char_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666044);
			CharPtr.NativeMethodInfoPtr_set_Item_Public_set_Void_UInt32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666045);
			CharPtr.NativeMethodInfoPtr_get_Item_Public_get_Char_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666046);
			CharPtr.NativeMethodInfoPtr_set_Item_Public_set_Void_Int64_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666047);
			CharPtr.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666051);
			CharPtr.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666052);
			CharPtr.NativeMethodInfoPtr__ctor_Public_Void_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666053);
			CharPtr.NativeMethodInfoPtr__ctor_Public_Void_CharPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666054);
			CharPtr.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666055);
			CharPtr.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666056);
			CharPtr.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666057);
			CharPtr.NativeMethodInfoPtr_op_Implicit_Public_Static_CharPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666048);
			CharPtr.NativeMethodInfoPtr_op_Implicit_Public_Static_CharPtr_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666049);
			CharPtr.NativeMethodInfoPtr_op_Implicit_Public_Static_CharPtr_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666050);
			CharPtr.NativeMethodInfoPtr_op_Addition_Public_Static_CharPtr_CharPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666059);
			CharPtr.NativeMethodInfoPtr_op_Subtraction_Public_Static_CharPtr_CharPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666060);
			CharPtr.NativeMethodInfoPtr_op_Addition_Public_Static_CharPtr_CharPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666061);
			CharPtr.NativeMethodInfoPtr_op_Subtraction_Public_Static_CharPtr_CharPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666062);
			CharPtr.NativeMethodInfoPtr_inc_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666063);
			CharPtr.NativeMethodInfoPtr_dec_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666064);
			CharPtr.NativeMethodInfoPtr_next_Public_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666065);
			CharPtr.NativeMethodInfoPtr_prev_Public_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666066);
			CharPtr.NativeMethodInfoPtr_add_Public_CharPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666067);
			CharPtr.NativeMethodInfoPtr_sub_Public_CharPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666068);
			CharPtr.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CharPtr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666069);
			CharPtr.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Char_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666070);
			CharPtr.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CharPtr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666071);
			CharPtr.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Char_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666072);
			CharPtr.NativeMethodInfoPtr_op_Addition_Public_Static_CharPtr_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666073);
			CharPtr.NativeMethodInfoPtr_op_Subtraction_Public_Static_Int32_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666074);
			CharPtr.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666075);
			CharPtr.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666076);
			CharPtr.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666077);
			CharPtr.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666078);
			CharPtr.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666079);
			CharPtr.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CharPtr_CharPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666080);
			CharPtr.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666081);
			CharPtr.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666082);
			CharPtr.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666083);
			CharPtr.NativeMethodInfoPtr_ToString_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharPtr>.NativeClassPtr, 100666084);
		}

		// Token: 0x170003AC RID: 940
		public unsafe char this[int offset]
		{
			[CallerCount(55)]
			[CachedScanResults(RefRangeStart = 39658, RefRangeEnd = 39713, XrefRangeStart = 39658, XrefRangeEnd = 39658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref offset;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_get_Item_Public_get_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 39713, RefRangeEnd = 39717, XrefRangeStart = 39713, XrefRangeEnd = 39713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref offset;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003AD RID: 941
		public unsafe char this[uint offset]
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 39718, RefRangeEnd = 39725, XrefRangeStart = 39717, XrefRangeEnd = 39718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref offset;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_get_Item_Public_get_Char_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39725, XrefRangeEnd = 39726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref offset;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_set_Item_Public_set_Void_UInt32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003AE RID: 942
		public unsafe char this[long offset]
		{
			[CallerCount(55)]
			[CachedScanResults(RefRangeStart = 39658, RefRangeEnd = 39713, XrefRangeStart = 39658, XrefRangeEnd = 39713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref offset;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_get_Item_Public_get_Char_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 39713, RefRangeEnd = 39717, XrefRangeStart = 39713, XrefRangeEnd = 39717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref offset;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_set_Item_Public_set_Void_Int64_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00053738 File Offset: 0x00051938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39726, XrefRangeEnd = 39728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharPtr()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharPtr>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00053774 File Offset: 0x00051974
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 39734, RefRangeEnd = 39739, XrefRangeStart = 39728, XrefRangeEnd = 39734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharPtr(string str)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharPtr>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x000537C0 File Offset: 0x000519C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 39741, RefRangeEnd = 39744, XrefRangeStart = 39739, XrefRangeEnd = 39741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharPtr(CharPtr ptr)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharPtr>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = IL2CPP.Il2CppObjectBaseToPtr(ptr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr__ctor_Public_Void_CharPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x0005380C File Offset: 0x00051A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39744, XrefRangeEnd = 39746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharPtr(CharPtr ptr, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharPtr>.NativeClassPtr))
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = IL2CPP.Il2CppObjectBaseToPtr(ptr);
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr__ctor_Public_Void_CharPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00053868 File Offset: 0x00051A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39746, XrefRangeEnd = 39748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharPtr(Il2CppStructArray<char> chars)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharPtr>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x000538B4 File Offset: 0x00051AB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 39750, RefRangeEnd = 39753, XrefRangeStart = 39748, XrefRangeEnd = 39750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharPtr(Il2CppStructArray<char> chars, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharPtr>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00053910 File Offset: 0x00051B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39753, XrefRangeEnd = 39759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharPtr(Il2CppStructArray<byte> bytes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharPtr>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0005395C File Offset: 0x00051B5C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 39763, RefRangeEnd = 39775, XrefRangeStart = 39759, XrefRangeEnd = 39763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator CharPtr(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_op_Implicit_Public_Static_CharPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
			}
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x000539A0 File Offset: 0x00051BA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 39780, RefRangeEnd = 39782, XrefRangeStart = 39775, XrefRangeEnd = 39780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator CharPtr(Il2CppStructArray<char> chars)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_op_Implicit_Public_Static_CharPtr_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
			}
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x000539E4 File Offset: 0x00051BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39782, XrefRangeEnd = 39791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator CharPtr(Il2CppStructArray<byte> bytes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_op_Implicit_Public_Static_CharPtr_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
			}
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00053A28 File Offset: 0x00051C28
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 39796, RefRangeEnd = 39820, XrefRangeStart = 39791, XrefRangeEnd = 39796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr operator +(CharPtr ptr, int offset)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = IL2CPP.Il2CppObjectBaseToPtr(ptr);
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_op_Addition_Public_Static_CharPtr_CharPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00053A7C File Offset: 0x00051C7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 39825, RefRangeEnd = 39829, XrefRangeStart = 39820, XrefRangeEnd = 39825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr operator -(CharPtr ptr, int offset)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = IL2CPP.Il2CppObjectBaseToPtr(ptr);
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_op_Subtraction_Public_Static_CharPtr_CharPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00053AD0 File Offset: 0x00051CD0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 39834, RefRangeEnd = 39840, XrefRangeStart = 39829, XrefRangeEnd = 39834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr operator +(CharPtr ptr, uint offset)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = IL2CPP.Il2CppObjectBaseToPtr(ptr);
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_op_Addition_Public_Static_CharPtr_CharPtr_UInt32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00053B24 File Offset: 0x00051D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39840, XrefRangeEnd = 39845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr operator -(CharPtr ptr, uint offset)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = IL2CPP.Il2CppObjectBaseToPtr(ptr);
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_op_Subtraction_Public_Static_CharPtr_CharPtr_UInt32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00053B78 File Offset: 0x00051D78
		[CallerCount(0)]
		public unsafe void inc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_inc_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00053BAC File Offset: 0x00051DAC
		[CallerCount(0)]
		public unsafe void dec()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_dec_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00053BE0 File Offset: 0x00051DE0
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 39850, RefRangeEnd = 39876, XrefRangeStart = 39845, XrefRangeEnd = 39850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharPtr next()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_next_Public_CharPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00053C20 File Offset: 0x00051E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39876, XrefRangeEnd = 39881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharPtr prev()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_prev_Public_CharPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00053C60 File Offset: 0x00051E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39881, XrefRangeEnd = 39886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharPtr add(int ofs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ofs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_add_Public_CharPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
			}
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00053CAC File Offset: 0x00051EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39886, XrefRangeEnd = 39891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharPtr sub(int ofs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ofs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_sub_Public_CharPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
			}
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00053CF8 File Offset: 0x00051EF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39891, RefRangeEnd = 39892, XrefRangeStart = 39891, XrefRangeEnd = 39891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(CharPtr ptr, char ch)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = IL2CPP.Il2CppObjectBaseToPtr(ptr);
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CharPtr_Char_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00053D48 File Offset: 0x00051F48
		[CallerCount(0)]
		public unsafe static bool operator ==(char ch, CharPtr ptr)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ch;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ptr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Char_CharPtr_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00053D98 File Offset: 0x00051F98
		[CallerCount(0)]
		public unsafe static bool operator !=(CharPtr ptr, char ch)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = IL2CPP.Il2CppObjectBaseToPtr(ptr);
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CharPtr_Char_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00053DE8 File Offset: 0x00051FE8
		[CallerCount(0)]
		public unsafe static bool operator !=(char ch, CharPtr ptr)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ch;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ptr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Char_CharPtr_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00053E38 File Offset: 0x00052038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39892, XrefRangeEnd = 39913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharPtr operator +(CharPtr ptr1, CharPtr ptr2)
		{
			IntPtr* ptr3;
			checked
			{
				ptr3 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr3 = IL2CPP.Il2CppObjectBaseToPtr(ptr1);
			}
			ptr3[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ptr2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_op_Addition_Public_Static_CharPtr_CharPtr_CharPtr_0, 0, (void**)ptr3, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharPtr>(intPtr3) : null;
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00053E90 File Offset: 0x00052090
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 39913, RefRangeEnd = 39926, XrefRangeStart = 39913, XrefRangeEnd = 39913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int operator -(CharPtr ptr1, CharPtr ptr2)
		{
			IntPtr* ptr3;
			checked
			{
				ptr3 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr3 = IL2CPP.Il2CppObjectBaseToPtr(ptr1);
			}
			ptr3[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ptr2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_op_Subtraction_Public_Static_Int32_CharPtr_CharPtr_0, 0, (void**)ptr3, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00053EE4 File Offset: 0x000520E4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 39926, RefRangeEnd = 39936, XrefRangeStart = 39926, XrefRangeEnd = 39926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(CharPtr ptr1, CharPtr ptr2)
		{
			IntPtr* ptr3;
			checked
			{
				ptr3 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr3 = IL2CPP.Il2CppObjectBaseToPtr(ptr1);
			}
			ptr3[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ptr2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_CharPtr_CharPtr_0, 0, (void**)ptr3, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00053F38 File Offset: 0x00052138
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39936, RefRangeEnd = 39937, XrefRangeStart = 39936, XrefRangeEnd = 39936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <=(CharPtr ptr1, CharPtr ptr2)
		{
			IntPtr* ptr3;
			checked
			{
				ptr3 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr3 = IL2CPP.Il2CppObjectBaseToPtr(ptr1);
			}
			ptr3[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ptr2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_CharPtr_CharPtr_0, 0, (void**)ptr3, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00053F8C File Offset: 0x0005218C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39937, RefRangeEnd = 39938, XrefRangeStart = 39937, XrefRangeEnd = 39937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >(CharPtr ptr1, CharPtr ptr2)
		{
			IntPtr* ptr3;
			checked
			{
				ptr3 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr3 = IL2CPP.Il2CppObjectBaseToPtr(ptr1);
			}
			ptr3[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ptr2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_CharPtr_CharPtr_0, 0, (void**)ptr3, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00053FE0 File Offset: 0x000521E0
		[CallerCount(0)]
		public unsafe static bool operator >=(CharPtr ptr1, CharPtr ptr2)
		{
			IntPtr* ptr3;
			checked
			{
				ptr3 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr3 = IL2CPP.Il2CppObjectBaseToPtr(ptr1);
			}
			ptr3[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ptr2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_CharPtr_CharPtr_0, 0, (void**)ptr3, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00054034 File Offset: 0x00052234
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 39938, RefRangeEnd = 39945, XrefRangeStart = 39938, XrefRangeEnd = 39938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(CharPtr ptr1, CharPtr ptr2)
		{
			IntPtr* ptr3;
			checked
			{
				ptr3 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr3 = IL2CPP.Il2CppObjectBaseToPtr(ptr1);
			}
			ptr3[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ptr2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CharPtr_CharPtr_0, 0, (void**)ptr3, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00054088 File Offset: 0x00052288
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 39945, RefRangeEnd = 39959, XrefRangeStart = 39945, XrefRangeEnd = 39945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(CharPtr ptr1, CharPtr ptr2)
		{
			IntPtr* ptr3;
			checked
			{
				ptr3 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr3 = IL2CPP.Il2CppObjectBaseToPtr(ptr1);
			}
			ptr3[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ptr2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CharPtr_CharPtr_0, 0, (void**)ptr3, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x000540DC File Offset: 0x000522DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39959, XrefRangeEnd = 39961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharPtr.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00054134 File Offset: 0x00052334
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharPtr.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0005417C File Offset: 0x0005237C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39961, XrefRangeEnd = 39969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharPtr.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x000541C0 File Offset: 0x000523C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 39977, RefRangeEnd = 39979, XrefRangeStart = 39969, XrefRangeEnd = 39977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharPtr.NativeMethodInfoPtr_ToString_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00006A32 File Offset: 0x00004C32
		public CharPtr(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x00054204 File Offset: 0x00052404
		// (set) Token: 0x06000F76 RID: 3958 RVA: 0x00006A3B File Offset: 0x00004C3B
		public unsafe Il2CppStructArray<char> chars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharPtr.NativeFieldInfoPtr_chars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharPtr.NativeFieldInfoPtr_chars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x00054234 File Offset: 0x00052434
		// (set) Token: 0x06000F78 RID: 3960 RVA: 0x00006A5A File Offset: 0x00004C5A
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharPtr.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharPtr.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeFieldInfoPtr_chars;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Char_Int32_0;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Char_0;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Char_UInt32_0;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_UInt32_Char_0;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Char_Int64_0;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int64_Char_0;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CharPtr_0;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CharPtr_Int32_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_CharPtr_String_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_CharPtr_Il2CppStructArray_1_Char_0;

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_CharPtr_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_CharPtr_CharPtr_Int32_0;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_CharPtr_CharPtr_Int32_0;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_CharPtr_CharPtr_UInt32_0;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_CharPtr_CharPtr_UInt32_0;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeMethodInfoPtr_inc_Public_Void_0;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeMethodInfoPtr_dec_Public_Void_0;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr_next_Public_CharPtr_0;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr_prev_Public_CharPtr_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_add_Public_CharPtr_Int32_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr_sub_Public_CharPtr_Int32_0;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CharPtr_Char_0;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Char_CharPtr_0;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CharPtr_Char_0;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Char_CharPtr_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_CharPtr_CharPtr_CharPtr_0;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Int32_CharPtr_CharPtr_0;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_CharPtr_CharPtr_0;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_CharPtr_CharPtr_0;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_CharPtr_CharPtr_0;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_CharPtr_CharPtr_0;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CharPtr_CharPtr_0;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CharPtr_CharPtr_0;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_Int32_0;
	}
}
