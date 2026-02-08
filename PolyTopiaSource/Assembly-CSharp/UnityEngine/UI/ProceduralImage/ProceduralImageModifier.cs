using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UI.ProceduralImage
{
	// Token: 0x02000345 RID: 837
	public class ProceduralImageModifier : MonoBehaviour
	{
		// Token: 0x060048A0 RID: 18592 RVA: 0x001417AC File Offset: 0x0013F9AC
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralImageModifier()
		{
			Il2CppClassPointerStore<ProceduralImageModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI.ProceduralImage", "ProceduralImageModifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralImageModifier>.NativeClassPtr);
			ProceduralImageModifier.NativeFieldInfoPtr_graphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralImageModifier>.NativeClassPtr, "graphic");
			ProceduralImageModifier.NativeMethodInfoPtr_get__Graphic_Protected_get_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImageModifier>.NativeClassPtr, 100674900);
			ProceduralImageModifier.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImageModifier>.NativeClassPtr, 100674902);
			ProceduralImageModifier.NativeMethodInfoPtr_CalculateRadius_Public_Abstract_Virtual_New_Vector4_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralImageModifier>.NativeClassPtr, 100674901);
		}

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x060048A1 RID: 18593 RVA: 0x0014182C File Offset: 0x0013FA2C
		public unsafe Graphic _Graphic
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 143676, RefRangeEnd = 143679, XrefRangeStart = 143668, XrefRangeEnd = 143676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImageModifier.NativeMethodInfoPtr_get__Graphic_Protected_get_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr3) : null;
			}
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x0014186C File Offset: 0x0013FA6C
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralImageModifier()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralImageModifier>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralImageModifier.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x001418A8 File Offset: 0x0013FAA8
		[CallerCount(0)]
		public unsafe virtual Vector4 CalculateRadius(Rect imageRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(imageRect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralImageModifier.NativeMethodInfoPtr_CalculateRadius_Public_Abstract_Virtual_New_Vector4_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector4>(intPtr3) : null;
			}
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x0001B013 File Offset: 0x00019213
		public ProceduralImageModifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x060048A5 RID: 18597 RVA: 0x00141904 File Offset: 0x0013FB04
		// (set) Token: 0x060048A6 RID: 18598 RVA: 0x0001B01C File Offset: 0x0001921C
		public unsafe Graphic graphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralImageModifier.NativeFieldInfoPtr_graphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralImageModifier.NativeFieldInfoPtr_graphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400383E RID: 14398
		private static readonly IntPtr NativeFieldInfoPtr_graphic;

		// Token: 0x0400383F RID: 14399
		private static readonly IntPtr NativeMethodInfoPtr_get__Graphic_Protected_get_Graphic_0;

		// Token: 0x04003840 RID: 14400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04003841 RID: 14401
		private static readonly IntPtr NativeMethodInfoPtr_CalculateRadius_Public_Abstract_Virtual_New_Vector4_Rect_0;
	}
}
