using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200000E RID: 14
	public class GizmoCap2DCollection : global::Il2CppSystem.Object
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x00023C80 File Offset: 0x00021E80
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoCap2DCollection()
		{
			Il2CppClassPointerStore<GizmoCap2DCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoCap2DCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoCap2DCollection>.NativeClassPtr);
			GizmoCap2DCollection.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DCollection>.NativeClassPtr, "_caps");
			GizmoCap2DCollection.NativeFieldInfoPtr__handleIdToCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoCap2DCollection>.NativeClassPtr, "_handleIdToCap");
			GizmoCap2DCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DCollection>.NativeClassPtr, 100663414);
			GizmoCap2DCollection.NativeMethodInfoPtr_get_Item_Public_get_GizmoCap2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DCollection>.NativeClassPtr, 100663415);
			GizmoCap2DCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DCollection>.NativeClassPtr, 100663426);
			GizmoCap2DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_GizmoCap2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DCollection>.NativeClassPtr, 100663416);
			GizmoCap2DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DCollection>.NativeClassPtr, 100663417);
			GizmoCap2DCollection.NativeMethodInfoPtr_Add_Public_Void_GizmoCap2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DCollection>.NativeClassPtr, 100663418);
			GizmoCap2DCollection.NativeMethodInfoPtr_Remove_Public_Void_GizmoCap2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DCollection>.NativeClassPtr, 100663419);
			GizmoCap2DCollection.NativeMethodInfoPtr_Make2DHoverPriorityLowerThan_Public_Void_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DCollection>.NativeClassPtr, 100663420);
			GizmoCap2DCollection.NativeMethodInfoPtr_Make2DHoverPriorityHigherThan_Public_Void_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DCollection>.NativeClassPtr, 100663421);
			GizmoCap2DCollection.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DCollection>.NativeClassPtr, 100663422);
			GizmoCap2DCollection.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DCollection>.NativeClassPtr, 100663423);
			GizmoCap2DCollection.NativeMethodInfoPtr_SetDragSession_Public_Void_IGizmoDragSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DCollection>.NativeClassPtr, 100663424);
			GizmoCap2DCollection.NativeMethodInfoPtr_Render_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoCap2DCollection>.NativeClassPtr, 100663425);
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00023DDC File Offset: 0x00021FDC
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56971, XrefRangeEnd = 56972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000034 RID: 52
		public unsafe GizmoCap2D this[int id]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56972, XrefRangeEnd = 56976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DCollection.NativeMethodInfoPtr_get_Item_Public_get_GizmoCap2D_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap2D>(intPtr3) : null;
				}
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00023E64 File Offset: 0x00022064
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56991, RefRangeEnd = 56993, XrefRangeStart = 56976, XrefRangeEnd = 56991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoCap2DCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoCap2DCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00023EA0 File Offset: 0x000220A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56993, XrefRangeEnd = 56997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(GizmoCap2D cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_GizmoCap2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00023EF0 File Offset: 0x000220F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 57001, RefRangeEnd = 57005, XrefRangeStart = 56997, XrefRangeEnd = 57001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(int capHandleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capHandleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DCollection.NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00023F3C File Offset: 0x0002213C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 57016, RefRangeEnd = 57022, XrefRangeStart = 57005, XrefRangeEnd = 57016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(GizmoCap2D cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DCollection.NativeMethodInfoPtr_Add_Public_Void_GizmoCap2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00023F80 File Offset: 0x00022180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57022, XrefRangeEnd = 57031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(GizmoCap2D cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DCollection.NativeMethodInfoPtr_Remove_Public_Void_GizmoCap2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00023FC4 File Offset: 0x000221C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57031, XrefRangeEnd = 57046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Make2DHoverPriorityLowerThan(Priority priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(priority);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DCollection.NativeMethodInfoPtr_Make2DHoverPriorityLowerThan_Public_Void_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00024008 File Offset: 0x00022208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57046, XrefRangeEnd = 57061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Make2DHoverPriorityHigherThan(Priority priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(priority);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DCollection.NativeMethodInfoPtr_Make2DHoverPriorityHigherThan_Public_Void_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0002404C File Offset: 0x0002224C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57075, RefRangeEnd = 57076, XrefRangeStart = 57061, XrefRangeEnd = 57075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DCollection.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0002408C File Offset: 0x0002228C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57090, RefRangeEnd = 57091, XrefRangeStart = 57076, XrefRangeEnd = 57090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHoverable(bool hoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DCollection.NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000240CC File Offset: 0x000222CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57106, RefRangeEnd = 57107, XrefRangeStart = 57091, XrefRangeEnd = 57106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDragSession(IGizmoDragSession dragSession)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragSession);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DCollection.NativeMethodInfoPtr_SetDragSession_Public_Void_IGizmoDragSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00024110 File Offset: 0x00022310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57107, XrefRangeEnd = 57121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoCap2DCollection.NativeMethodInfoPtr_Render_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002498 File Offset: 0x00000698
		public GizmoCap2DCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00024154 File Offset: 0x00022354
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x000024A1 File Offset: 0x000006A1
		public unsafe List<GizmoCap2D> _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DCollection.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GizmoCap2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DCollection.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00024184 File Offset: 0x00022384
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x000024C0 File Offset: 0x000006C0
		public unsafe Dictionary<int, GizmoCap2D> _handleIdToCap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DCollection.NativeFieldInfoPtr__handleIdToCap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GizmoCap2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoCap2DCollection.NativeFieldInfoPtr__handleIdToCap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr__handleIdToCap;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_GizmoCap2D_Int32_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_GizmoCap2D_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int32_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_GizmoCap2D_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_GizmoCap2D_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_Make2DHoverPriorityLowerThan_Public_Void_Priority_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_Make2DHoverPriorityHigherThan_Public_Void_Priority_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_SetHoverable_Public_Void_Boolean_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_SetDragSession_Public_Void_IGizmoDragSession_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_Camera_0;
	}
}
