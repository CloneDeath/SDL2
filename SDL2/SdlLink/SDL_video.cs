using System;
using System.Runtime.InteropServices;

namespace SDL2.SdlLink {
	public static partial class SdlInternal {
		[DllImport(SdlName)]
		public static extern IntPtr SDL_CreateWindow(string title, int x, int y, int w, int h, SDL_WindowFlags flags);
		
		[DllImport(SdlName)]
		public static extern void SDL_DestroyWindow(IntPtr window);

		[DllImport(SdlName)]
		public static extern void SDL_SetWindowTitle(IntPtr window, string title);

		[DllImport(SdlName)]
		public static extern string SDL_GetWindowTitle(IntPtr window);
	}
}