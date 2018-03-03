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
		
		[DllImport(SdlName)]
		public static extern void SDL_SetWindowPosition(IntPtr window, int x, int y);

		[DllImport(SdlName)]
		public static extern void SDL_GetWindowPosition(IntPtr window, out int x, out int y);
		
		[DllImport(SdlName)]
		public static extern void SDL_SetWindowSize(IntPtr window, int w, int h);
		
		[DllImport(SdlName)]
		public static extern void SDL_GetWindowSize(IntPtr window, out int w, out int h);
		
		[DllImport(SdlName)]
		public static extern void SDL_SetWindowMinimumSize(IntPtr window, int w, int h);
		
		[DllImport(SdlName)]
		public static extern void SDL_GetWindowMinimumSize(IntPtr window, out int w, out int h);
		
		[DllImport(SdlName)]
		public static extern void SDL_SetWindowMaximumSize(IntPtr window, int w, int h);
		
		[DllImport(SdlName)]
		public static extern void SDL_GetWindowMaximumSize(IntPtr window, out int w, out int h);
		
		[DllImport(SdlName)]
		public static extern void SDL_SetWindowBordered(IntPtr window, bool bordered);
		
		[DllImport(SdlName)]
		public static extern void SDL_SetWindowResizable(IntPtr window, bool resizable);
		
		[DllImport(SdlName)]
		public static extern void SDL_ShowWindow(IntPtr window);
		
		[DllImport(SdlName)]
		public static extern void SDL_HideWindow(IntPtr window);
		
		[DllImport(SdlName)]
		public static extern void SDL_RaiseWindow(IntPtr window);
		
		[DllImport(SdlName)]
		public static extern void SDL_MaximizeWindow(IntPtr window);
		
		[DllImport(SdlName)]
		public static extern void SDL_MinimizeWindow(IntPtr window);
		
		[DllImport(SdlName)]
		public static extern void SDL_RestoreWindow(IntPtr window);
		
		[DllImport(SdlName)]
		public static extern int SDL_SetWindowFullscreen(IntPtr window, SDL_WindowFlags flags);
		
		[DllImport(SdlName)]
		public static extern bool SDL_IsScreenSaverEnabled();
		
		[DllImport(SdlName)]
		public static extern void SDL_EnableScreenSaver();
		
		[DllImport(SdlName)]
		public static extern void SDL_DisableScreenSaver();

	}
}