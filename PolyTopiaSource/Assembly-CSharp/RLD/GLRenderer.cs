using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001A4 RID: 420
	public static class GLRenderer : global::Il2CppSystem.Object
	{
		// Token: 0x06002067 RID: 8295 RVA: 0x000A25D8 File Offset: 0x000A07D8
		// Note: this type is marked as 'beforefieldinit'.
		static GLRenderer()
		{
			Il2CppClassPointerStore<GLRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GLRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr);
			GLRenderer.NativeMethodInfoPtr_DrawQuads2D_Public_Static_Void_List_1_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668248);
			GLRenderer.NativeMethodInfoPtr_DrawLineLoop2D_Public_Static_Void_List_1_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668249);
			GLRenderer.NativeMethodInfoPtr_DrawLineLoop2D_Public_Static_Void_List_1_Vector2_Vector2_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668250);
			GLRenderer.NativeMethodInfoPtr_DrawLines2D_Public_Static_Void_List_1_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668251);
			GLRenderer.NativeMethodInfoPtr_DrawLines2D_Public_Static_Void_List_1_Vector2_Vector2_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668252);
			GLRenderer.NativeMethodInfoPtr_DrawLine2D_Public_Static_Void_Vector2_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668253);
			GLRenderer.NativeMethodInfoPtr_DrawLine3D_Public_Static_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668254);
			GLRenderer.NativeMethodInfoPtr_DrawLines3D_Public_Static_Void_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668255);
			GLRenderer.NativeMethodInfoPtr_DrawLineLoop3D_Public_Static_Void_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668256);
			GLRenderer.NativeMethodInfoPtr_DrawLineStrip3D_Public_Static_Void_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668257);
			GLRenderer.NativeMethodInfoPtr_DrawLineLoop3D_Public_Static_Void_List_1_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668258);
			GLRenderer.NativeMethodInfoPtr_DrawLinePairs3D_Public_Static_Void_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668259);
			GLRenderer.NativeMethodInfoPtr_DrawRectBorder2D_Public_Static_Void_Rect_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668260);
			GLRenderer.NativeMethodInfoPtr_DrawRect2D_Public_Static_Void_Rect_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668261);
			GLRenderer.NativeMethodInfoPtr_DrawCircleBorder2D_Public_Static_Void_Vector2_Single_Int32_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668262);
			GLRenderer.NativeMethodInfoPtr_DrawCircle2D_Public_Static_Void_Vector2_Single_Int32_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668263);
			GLRenderer.NativeMethodInfoPtr_DrawCircleBorder3D_Public_Static_Void_Vector3_Single_Vector3_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668264);
			GLRenderer.NativeMethodInfoPtr_DrawCircle3D_Public_Static_Void_Vector2_Single_Vector3_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668265);
			GLRenderer.NativeMethodInfoPtr_DrawSphereBorder_Public_Static_Void_Camera_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668266);
			GLRenderer.NativeMethodInfoPtr_DrawTriangleFan2D_Public_Static_Void_Vector2_List_1_Vector2_Vector2_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668267);
			GLRenderer.NativeMethodInfoPtr_DrawTriangleFan2D_Public_Static_Void_Vector2_List_1_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668268);
			GLRenderer.NativeMethodInfoPtr_DrawTriangleFan3D_Public_Static_Void_Vector3_List_1_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668269);
			GLRenderer.NativeMethodInfoPtr_DrawTriangleFan3D_Public_Static_Void_Vector3_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GLRenderer>.NativeClassPtr, 100668270);
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x000A27D4 File Offset: 0x000A09D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84803, RefRangeEnd = 84804, XrefRangeStart = 84780, XrefRangeEnd = 84803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawQuads2D(List<Vector2> quadPoints, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(quadPoints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawQuads2D_Public_Static_Void_List_1_Vector2_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x000A281C File Offset: 0x000A0A1C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 84820, RefRangeEnd = 84827, XrefRangeStart = 84804, XrefRangeEnd = 84820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineLoop2D(List<Vector2> linePoints, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(linePoints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawLineLoop2D_Public_Static_Void_List_1_Vector2_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x000A2864 File Offset: 0x000A0A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84827, XrefRangeEnd = 84843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineLoop2D(List<Vector2> linePoints, Vector2 translation, Vector2 scale, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(linePoints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(translation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scale);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawLineLoop2D_Public_Static_Void_List_1_Vector2_Vector2_Vector2_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x000A28D0 File Offset: 0x000A0AD0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 84859, RefRangeEnd = 84866, XrefRangeStart = 84843, XrefRangeEnd = 84859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLines2D(List<Vector2> linePoints, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(linePoints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawLines2D_Public_Static_Void_List_1_Vector2_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x000A2918 File Offset: 0x000A0B18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84882, RefRangeEnd = 84883, XrefRangeStart = 84866, XrefRangeEnd = 84882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLines2D(List<Vector2> linePoints, Vector2 translation, Vector2 scale, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(linePoints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(translation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scale);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawLines2D_Public_Static_Void_List_1_Vector2_Vector2_Vector2_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x000A2984 File Offset: 0x000A0B84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84893, RefRangeEnd = 84895, XrefRangeStart = 84883, XrefRangeEnd = 84893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine2D(Vector2 startPoint, Vector2 endPoint, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startPoint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endPoint);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawLine2D_Public_Static_Void_Vector2_Vector2_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x000A29E0 File Offset: 0x000A0BE0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 84899, RefRangeEnd = 84908, XrefRangeStart = 84895, XrefRangeEnd = 84899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLine3D(Vector3 startPoint, Vector3 endPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startPoint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endPoint);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawLine3D_Public_Static_Void_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x000A2A28 File Offset: 0x000A0C28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84919, RefRangeEnd = 84922, XrefRangeStart = 84908, XrefRangeEnd = 84919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLines3D(List<Vector3> linePoints)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(linePoints);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawLines3D_Public_Static_Void_List_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x000A2A60 File Offset: 0x000A0C60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84933, RefRangeEnd = 84935, XrefRangeStart = 84922, XrefRangeEnd = 84933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineLoop3D(List<Vector3> linePoints)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(linePoints);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawLineLoop3D_Public_Static_Void_List_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x000A2A98 File Offset: 0x000A0C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84935, XrefRangeEnd = 84946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineStrip3D(List<Vector3> linePoints)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(linePoints);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawLineStrip3D_Public_Static_Void_List_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x000A2AD0 File Offset: 0x000A0CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84946, XrefRangeEnd = 84957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLineLoop3D(List<Vector3> linePoints, Vector3 pointOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(linePoints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pointOffset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawLineLoop3D_Public_Static_Void_List_1_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x000A2B18 File Offset: 0x000A0D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84968, RefRangeEnd = 84969, XrefRangeStart = 84957, XrefRangeEnd = 84968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawLinePairs3D(List<Vector3> pairPoints)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pairPoints);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawLinePairs3D_Public_Static_Void_List_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x000A2B50 File Offset: 0x000A0D50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84971, RefRangeEnd = 84973, XrefRangeStart = 84969, XrefRangeEnd = 84971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawRectBorder2D(Rect rect, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawRectBorder2D_Public_Static_Void_Rect_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x000A2B98 File Offset: 0x000A0D98
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 85014, RefRangeEnd = 85019, XrefRangeStart = 84973, XrefRangeEnd = 85014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawRect2D(Rect rect, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawRect2D_Public_Static_Void_Rect_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x000A2BE0 File Offset: 0x000A0DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85019, XrefRangeEnd = 85021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawCircleBorder2D(Vector2 circleCenter, float circleRadius, int numPoints, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(circleCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPoints;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawCircleBorder2D_Public_Static_Void_Vector2_Single_Int32_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x000A2C44 File Offset: 0x000A0E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85021, XrefRangeEnd = 85023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawCircle2D(Vector2 circleCenter, float circleRadius, int numPoints, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(circleCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPoints;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawCircle2D_Public_Static_Void_Vector2_Single_Int32_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x000A2CA8 File Offset: 0x000A0EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85023, XrefRangeEnd = 85025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawCircleBorder3D(Vector3 circleCenter, float circleRadius, Vector3 circleRight, Vector3 circleUp, int numPoints)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(circleCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(circleRight);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(circleUp);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPoints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawCircleBorder3D_Public_Static_Void_Vector3_Single_Vector3_Vector3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x000A2D20 File Offset: 0x000A0F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85025, XrefRangeEnd = 85037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawCircle3D(Vector2 circleCenter, float circleRadius, Vector3 circleRight, Vector3 circleUp, int numPoints)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(circleCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(circleRight);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(circleUp);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPoints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawCircle3D_Public_Static_Void_Vector2_Single_Vector3_Vector3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x000A2D98 File Offset: 0x000A0F98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85039, RefRangeEnd = 85040, XrefRangeStart = 85037, XrefRangeEnd = 85039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawSphereBorder(Camera camera, Vector3 sphereCenter, float sphereRadius, int numPoints)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sphereCenter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sphereRadius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPoints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawSphereBorder_Public_Static_Void_Camera_Vector3_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x000A2DFC File Offset: 0x000A0FFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85057, RefRangeEnd = 85058, XrefRangeStart = 85040, XrefRangeEnd = 85057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawTriangleFan2D(Vector2 origin, List<Vector2> points, Vector2 translation, Vector2 scale, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(origin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(translation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scale);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawTriangleFan2D_Public_Static_Void_Vector2_List_1_Vector2_Vector2_Vector2_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x000A2E7C File Offset: 0x000A107C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 85075, RefRangeEnd = 85083, XrefRangeStart = 85058, XrefRangeEnd = 85075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawTriangleFan2D(Vector2 origin, List<Vector2> points, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(origin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawTriangleFan2D_Public_Static_Void_Vector2_List_1_Vector2_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x000A2ED8 File Offset: 0x000A10D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85083, XrefRangeEnd = 85094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawTriangleFan3D(Vector3 origin, List<Vector3> points, Vector3 translation, Vector3 scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(origin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(translation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawTriangleFan3D_Public_Static_Void_Vector3_List_1_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x000A2F44 File Offset: 0x000A1144
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85105, RefRangeEnd = 85106, XrefRangeStart = 85094, XrefRangeEnd = 85105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawTriangleFan3D(Vector3 origin, List<Vector3> points)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(origin);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GLRenderer.NativeMethodInfoPtr_DrawTriangleFan3D_Public_Static_Void_Vector3_List_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x0000D26F File Offset: 0x0000B46F
		public GLRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001953 RID: 6483
		private static readonly IntPtr NativeMethodInfoPtr_DrawQuads2D_Public_Static_Void_List_1_Vector2_Camera_0;

		// Token: 0x04001954 RID: 6484
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineLoop2D_Public_Static_Void_List_1_Vector2_Camera_0;

		// Token: 0x04001955 RID: 6485
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineLoop2D_Public_Static_Void_List_1_Vector2_Vector2_Vector2_Camera_0;

		// Token: 0x04001956 RID: 6486
		private static readonly IntPtr NativeMethodInfoPtr_DrawLines2D_Public_Static_Void_List_1_Vector2_Camera_0;

		// Token: 0x04001957 RID: 6487
		private static readonly IntPtr NativeMethodInfoPtr_DrawLines2D_Public_Static_Void_List_1_Vector2_Vector2_Vector2_Camera_0;

		// Token: 0x04001958 RID: 6488
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine2D_Public_Static_Void_Vector2_Vector2_Camera_0;

		// Token: 0x04001959 RID: 6489
		private static readonly IntPtr NativeMethodInfoPtr_DrawLine3D_Public_Static_Void_Vector3_Vector3_0;

		// Token: 0x0400195A RID: 6490
		private static readonly IntPtr NativeMethodInfoPtr_DrawLines3D_Public_Static_Void_List_1_Vector3_0;

		// Token: 0x0400195B RID: 6491
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineLoop3D_Public_Static_Void_List_1_Vector3_0;

		// Token: 0x0400195C RID: 6492
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineStrip3D_Public_Static_Void_List_1_Vector3_0;

		// Token: 0x0400195D RID: 6493
		private static readonly IntPtr NativeMethodInfoPtr_DrawLineLoop3D_Public_Static_Void_List_1_Vector3_Vector3_0;

		// Token: 0x0400195E RID: 6494
		private static readonly IntPtr NativeMethodInfoPtr_DrawLinePairs3D_Public_Static_Void_List_1_Vector3_0;

		// Token: 0x0400195F RID: 6495
		private static readonly IntPtr NativeMethodInfoPtr_DrawRectBorder2D_Public_Static_Void_Rect_Camera_0;

		// Token: 0x04001960 RID: 6496
		private static readonly IntPtr NativeMethodInfoPtr_DrawRect2D_Public_Static_Void_Rect_Camera_0;

		// Token: 0x04001961 RID: 6497
		private static readonly IntPtr NativeMethodInfoPtr_DrawCircleBorder2D_Public_Static_Void_Vector2_Single_Int32_Camera_0;

		// Token: 0x04001962 RID: 6498
		private static readonly IntPtr NativeMethodInfoPtr_DrawCircle2D_Public_Static_Void_Vector2_Single_Int32_Camera_0;

		// Token: 0x04001963 RID: 6499
		private static readonly IntPtr NativeMethodInfoPtr_DrawCircleBorder3D_Public_Static_Void_Vector3_Single_Vector3_Vector3_Int32_0;

		// Token: 0x04001964 RID: 6500
		private static readonly IntPtr NativeMethodInfoPtr_DrawCircle3D_Public_Static_Void_Vector2_Single_Vector3_Vector3_Int32_0;

		// Token: 0x04001965 RID: 6501
		private static readonly IntPtr NativeMethodInfoPtr_DrawSphereBorder_Public_Static_Void_Camera_Vector3_Single_Int32_0;

		// Token: 0x04001966 RID: 6502
		private static readonly IntPtr NativeMethodInfoPtr_DrawTriangleFan2D_Public_Static_Void_Vector2_List_1_Vector2_Vector2_Vector2_Camera_0;

		// Token: 0x04001967 RID: 6503
		private static readonly IntPtr NativeMethodInfoPtr_DrawTriangleFan2D_Public_Static_Void_Vector2_List_1_Vector2_Camera_0;

		// Token: 0x04001968 RID: 6504
		private static readonly IntPtr NativeMethodInfoPtr_DrawTriangleFan3D_Public_Static_Void_Vector3_List_1_Vector3_Vector3_Vector3_0;

		// Token: 0x04001969 RID: 6505
		private static readonly IntPtr NativeMethodInfoPtr_DrawTriangleFan3D_Public_Static_Void_Vector3_List_1_Vector3_0;
	}
}
