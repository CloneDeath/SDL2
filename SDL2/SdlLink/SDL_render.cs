using System;
using System.Runtime.InteropServices;

namespace SDL2.SdlLink {
	public static partial class Sdl {
		[DllImport(SdlName, EntryPoint = "SDL_CreateRenderer")]
		public static extern IntPtr CreateRenderer(IntPtr window, int index, SDL_RendererFlags flags);
		
		[DllImport(SdlName, EntryPoint = "SDL_CreateSoftwareRenderer")]
		public static extern IntPtr CreateSoftwareRenderer(IntPtr surface);
		
		[DllImport(SdlName, EntryPoint = "SDL_CreateTexture")]
		public static extern IntPtr CreateTexture(IntPtr renderer, uint format, int access, int w, int h);
		
		[DllImport(SdlName, EntryPoint = "SDL_CreateTextureFromSurface")]
		public static extern IntPtr CreateTextureFromSurface(IntPtr renderer, IntPtr surface);

		[DllImport(SdlName, EntryPoint = "SDL_QueryTexture")]
		public static extern int QueryTexture(IntPtr texture, out uint format, out int access, out int w, out int h);
		
		[DllImport(SdlName, EntryPoint = "SDL_SetRenderTarget")]
		public static extern int SetRenderTarget(IntPtr renderer, IntPtr texture);
		
		[DllImport(SdlName, EntryPoint = "SDL_GetRenderTarget")]
		public static extern IntPtr GetRenderTarget(IntPtr renderer);

		[DllImport(SdlName, EntryPoint = "SDL_RenderSetLogicalSize")]
		public static extern int RenderSetLogicalSize(IntPtr renderer, int w, int h);

		[DllImport(SdlName, EntryPoint = "SDL_RenderGetLogicalSize")]
		public static extern void RenderGetLogicalSize(IntPtr renderer, out int w, out int h);

		[DllImport(SdlName, EntryPoint = "SDL_RenderSetIntegerScale")]
		public static extern int RenderSetIntegerScale(IntPtr renderer, bool enable);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderGetIntegerScale")]
		public static extern bool RenderGetIntegerScale(IntPtr renderer);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderSetViewport")]
		public static extern int RenderSetViewport(IntPtr renderer, ref SDL_Rect rect);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderSetViewport")]
		public static extern int RenderSetViewport(IntPtr renderer, IntPtr rect);

		[DllImport(SdlName, EntryPoint = "SDL_RenderGetViewport")]
		public static extern void RenderGetViewport(IntPtr renderer, out SDL_Rect rect);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderSetClipRect")]
		public static extern int RenderSetClipRect(IntPtr renderer, ref SDL_Rect rect);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderSetClipRect")]
		public static extern int RenderSetClipRect(IntPtr renderer, IntPtr rect);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderGetClipRect")]
		public static extern void RenderGetClipRect(IntPtr renderer, out SDL_Rect rect);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderIsClipEnabled")]
		public static extern bool RenderIsClipEnabled(IntPtr renderer);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderSetScale")]
		public static extern int RenderSetScale(IntPtr renderer, float scaleX, float scaleY);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderGetScale")]
		public static extern void RenderGetScale(IntPtr renderer, out float scaleX, out float scaleY);
		
		[DllImport(SdlName, EntryPoint = "SDL_SetRenderDrawColor")]
		public static extern int SetRenderDrawColor(IntPtr renderer, byte r, byte g, byte b, byte a);
		
		[DllImport(SdlName, EntryPoint = "SDL_GetRenderDrawColor")]
		public static extern int GetRenderDrawColor(IntPtr renderer, out byte r, out byte g, out byte b, out byte a);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderClear")]
		public static extern int RenderClear(IntPtr renderer);

		[DllImport(SdlName, EntryPoint = "SDL_RenderDrawPoint")]
		public static extern int RenderDrawPoint(IntPtr renderer, int x, int y);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderDrawPoints")]
		public static extern int RenderDrawPoints(IntPtr renderer, ref SDL_Point[] points, int count);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderDrawLine")]
		public static extern int RenderDrawLine(IntPtr renderer, int x1, int y1, int x2, int y2);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderDrawLines")]
		public static extern int RenderDrawLines(IntPtr renderer, ref SDL_Point[] points, int count);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderDrawRect")]
		public static extern int RenderDrawRect(IntPtr renderer, ref SDL_Rect rect);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderDrawRects")]
		public static extern int RenderDrawRects(IntPtr renderer, ref SDL_Rect[] rects, int count);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderFillRect")]
		public static extern int RenderFillRect(IntPtr renderer, ref SDL_Rect rect);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderFillRects")]
		public static extern int RenderFillRects(IntPtr renderer, ref SDL_Rect[] rects, int count);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderCopy")]
		public static extern int RenderCopy(IntPtr renderer, IntPtr texture, ref SDL_Rect srcrect, ref SDL_Rect dstrect);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderCopyEx")]
		public static extern int RenderCopyEx(IntPtr renderer, IntPtr texture, ref SDL_Rect srcrect, ref SDL_Rect dstrect, double angle, ref SDL_Point center, SDL_RendererFlip flip);
		
		[DllImport(SdlName, EntryPoint = "SDL_RenderPresent")]
		public static extern void RenderPresent(IntPtr renderer);
		
		[DllImport(SdlName, EntryPoint = "SDL_DestroyTexture")]
		public static extern void DestroyTexture(IntPtr texture);
		
		[DllImport(SdlName, EntryPoint = "SDL_DestroyRenderer")]
		public static extern void DestroyRenderer(IntPtr renderer);
	}
}