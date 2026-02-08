using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000002 RID: 2
public class ScreamStateBehaviour : StateMachineBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00020EF8 File Offset: 0x0001F0F8
	// Note: this type is marked as 'beforefieldinit'.
	static ScreamStateBehaviour()
	{
		Il2CppClassPointerStore<ScreamStateBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ScreamStateBehaviour");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreamStateBehaviour>.NativeClassPtr);
		ScreamStateBehaviour.NativeFieldInfoPtr_face = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreamStateBehaviour>.NativeClassPtr, "face");
		ScreamStateBehaviour.NativeFieldInfoPtr_oldFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreamStateBehaviour>.NativeClassPtr, "oldFace");
		ScreamStateBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreamStateBehaviour>.NativeClassPtr, 100663299);
		ScreamStateBehaviour.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreamStateBehaviour>.NativeClassPtr, 100663297);
		ScreamStateBehaviour.NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreamStateBehaviour>.NativeClassPtr, 100663298);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00020F8C File Offset: 0x0001F18C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55612, XrefRangeEnd = 55613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScreamStateBehaviour()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreamStateBehaviour>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreamStateBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00020FC8 File Offset: 0x0001F1C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55613, XrefRangeEnd = 55634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animator);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateInfo);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerIndex;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreamStateBehaviour.NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00021038 File Offset: 0x0001F238
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55634, XrefRangeEnd = 55648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animator);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateInfo);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerIndex;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreamStateBehaviour.NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	public ScreamStateBehaviour(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000006 RID: 6 RVA: 0x000210A8 File Offset: 0x0001F2A8
	// (set) Token: 0x06000007 RID: 7 RVA: 0x00002059 File Offset: 0x00000259
	public unsafe Texture2D face
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreamStateBehaviour.NativeFieldInfoPtr_face);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreamStateBehaviour.NativeFieldInfoPtr_face), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000008 RID: 8 RVA: 0x000210D8 File Offset: 0x0001F2D8
	// (set) Token: 0x06000009 RID: 9 RVA: 0x00002078 File Offset: 0x00000278
	public unsafe Texture2D oldFace
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreamStateBehaviour.NativeFieldInfoPtr_oldFace);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreamStateBehaviour.NativeFieldInfoPtr_oldFace), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000001 RID: 1
	private static readonly IntPtr NativeFieldInfoPtr_face;

	// Token: 0x04000002 RID: 2
	private static readonly IntPtr NativeFieldInfoPtr_oldFace;

	// Token: 0x04000003 RID: 3
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000004 RID: 4
	private static readonly IntPtr NativeMethodInfoPtr_OnStateEnter_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;

	// Token: 0x04000005 RID: 5
	private static readonly IntPtr NativeMethodInfoPtr_OnStateExit_Public_Virtual_Void_Animator_AnimatorStateInfo_Int32_0;
}
