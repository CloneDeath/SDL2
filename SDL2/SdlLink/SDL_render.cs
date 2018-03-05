using System;
using System.Runtime.InteropServices;

namespace SDL2.SdlLink {
	public static partial class SdlInternal {
		[DllImport(SdlName)]
		public static extern IntPtr SDL_CreateRenderer(IntPtr window, int index, SDL_RendererFlags flags);
		
		[DllImport(SdlName)]
		public static extern IntPtr SDL_CreateTexture(IntPtr renderer, uint format, int access, int w, int h);
		
		[DllImport(SdlName)]
		public static extern IntPtr SDL_CreateTextureFromSurface(IntPtr renderer, IntPtr surface);

		[DllImport(SdlName)]
		public static extern int SDL_QueryTexture(IntPtr texture, out uint format, out int access, out int w, out int h);
		
		[DllImport(SdlName)]
		public static extern int SDL_SetRenderTarget(IntPtr renderer, IntPtr texture);
		
		[DllImport(SdlName)]
		public static extern IntPtr SDL_GetRenderTarget(IntPtr renderer);

		[DllImport(SdlName)]
		public static extern int SDL_RenderSetLogicalSize(IntPtr renderer, int w, int h);

		[DllImport(SdlName)]
		public static extern void SDL_RenderGetLogicalSize(IntPtr renderer, out int w, out int h);

		[DllImport(SdlName)]
		public static extern int SDL_RenderSetIntegerScale(IntPtr renderer, bool enable);
		
		[DllImport(SdlName)]
		public static extern bool SDL_RenderGetIntegerScale(IntPtr renderer);
		
		[DllImport(SdlName)]
		public static extern int SDL_RenderSetViewport(IntPtr renderer, ref SDL_Rect rect);

		[DllImport(SdlName)]
		public static extern void SDL_RenderGetViewport(IntPtr renderer, out SDL_Rect rect);
		
		[DllImport(SdlName)]
		public static extern int SDL_RenderSetClipRect(IntPtr renderer, ref SDL_Rect rect);
		
		[DllImport(SdlName)]
		public static extern void SDL_RenderGetClipRect(IntPtr renderer, out SDL_Rect rect);
		
		[DllImport(SdlName)]
		public static extern int SDL_RenderSetScale(IntPtr renderer, float scaleX, float scaleY);
		
		[DllImport(SdlName)]
		public static extern void SDL_RenderGetScale(IntPtr renderer, out float scaleX, out float scaleY);
		
		[DllImport(SdlName)]
		public static extern int SDL_SetRenderDrawColor(IntPtr renderer, byte r, byte g, byte b, byte a);
		
		[DllImport(SdlName)]
		public static extern int SDL_GetRenderDrawColor(IntPtr renderer, out byte r, out byte g, out byte b, out byte a);
		
		[DllImport(SdlName)]
		public static extern int SDL_RenderClear(IntPtr renderer);

		[DllImport(SdlName)]
		public static extern int SDL_RenderDrawPoint(IntPtr renderer, int x, int y);
		
		[DllImport(SdlName)]
		public static extern int SDL_RenderDrawPoints(IntPtr renderer, ref SDL_Point[] points, int count);
		
		[DllImport(SdlName)]
		public static extern int SDL_RenderDrawLine(IntPtr renderer, int x1, int y1, int x2, int y2);
		
		[DllImport(SdlName)]
		public static extern int SDL_RenderDrawLines(IntPtr renderer, ref SDL_Point[] points, int count);
		
		[DllImport(SdlName)]
		public static extern int SDL_RenderDrawRect(IntPtr renderer, ref SDL_Rect rect);
		
		[DllImport(SdlName)]
		public static extern int SDL_RenderDrawRects(IntPtr renderer, ref SDL_Rect[] rects, int count);
		
		[DllImport(SdlName)]
		public static extern int SDL_RenderFillRect(IntPtr renderer, ref SDL_Rect rect);
		
		[DllImport(SdlName)]
		public static extern int SDL_RenderFillRects(IntPtr renderer, ref SDL_Rect[] rects, int count);
		
		[DllImport(SdlName)]
		public static extern int SDL_RenderCopy(IntPtr renderer, IntPtr texture, ref SDL_Rect srcrect, ref SDL_Rect dstrect);
		
		[DllImport(SdlName)]
		public static extern int SDL_RenderCopyEx(IntPtr renderer, IntPtr texture, ref SDL_Rect srcrect, ref SDL_Rect dstrect, double angle, ref SDL_Point center, SDL_RendererFlip flip);
		
		[DllImport(SdlName)]
		public static extern void SDL_RenderPresent(IntPtr renderer);
		
		[DllImport(SdlName)]
		public static extern void SDL_DestroyTexture(IntPtr texture);
		
		[DllImport(SdlName)]
		public static extern void SDL_DestroyRenderer(IntPtr renderer);
	}
}