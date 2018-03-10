using System;
using System.Runtime.InteropServices;

namespace SDL2.SdlLink {
	public static partial class Sdl {
		[DllImport(SdlName, EntryPoint = "SDL_CreateWindow")]
		public static extern IntPtr CreateWindow(string title, int x, int y, int w, int h, SDL_WindowFlags flags);
		
		[DllImport(SdlName, EntryPoint = "SDL_DestroyWindow")]
		public static extern void DestroyWindow(IntPtr window);

		[DllImport(SdlName, EntryPoint = "SDL_SetWindowTitle")]
		public static extern void SetWindowTitle(IntPtr window, string title);

		[DllImport(SdlName, EntryPoint = "SDL_GetWindowTitle")]
		public static extern string GetWindowTitle(IntPtr window);
		
		[DllImport(SdlName, EntryPoint = "SDL_SetWindowPosition")]
		public static extern void SetWindowPosition(IntPtr window, int x, int y);

		[DllImport(SdlName, EntryPoint = "SDL_GetWindowPosition")]
		public static extern void GetWindowPosition(IntPtr window, out int x, out int y);
		
		[DllImport(SdlName, EntryPoint = "SDL_SetWindowSize")]
		public static extern void SetWindowSize(IntPtr window, int w, int h);
		
		[DllImport(SdlName, EntryPoint = "SDL_GetWindowSize")]
		public static extern void GetWindowSize(IntPtr window, out int w, out int h);
		
		[DllImport(SdlName, EntryPoint = "SDL_SetWindowMinimumSize")]
		public static extern void SetWindowMinimumSize(IntPtr window, int w, int h);
		
		[DllImport(SdlName, EntryPoint = "SDL_GetWindowMinimumSize")]
		public static extern void GetWindowMinimumSize(IntPtr window, out int w, out int h);
		
		[DllImport(SdlName, EntryPoint = "SDL_SetWindowMaximumSize")]
		public static extern void SetWindowMaximumSize(IntPtr window, int w, int h);
		
		[DllImport(SdlName, EntryPoint = "SDL_GetWindowMaximumSize")]
		public static extern void GetWindowMaximumSize(IntPtr window, out int w, out int h);
		
		[DllImport(SdlName, EntryPoint = "SDL_GetWindowFlags")]
		public static extern SDL_WindowFlags GetWindowFlags(IntPtr window);
		
		[DllImport(SdlName, EntryPoint = "SDL_SetWindowBordered")]
		public static extern void SetWindowBordered(IntPtr window, bool bordered);
		
		[DllImport(SdlName, EntryPoint = "SDL_SetWindowResizable")]
		public static extern void SetWindowResizable(IntPtr window, bool resizable);
		
		[DllImport(SdlName, EntryPoint = "SDL_ShowWindow")]
		public static extern void ShowWindow(IntPtr window);
		
		[DllImport(SdlName, EntryPoint = "SDL_HideWindow")]
		public static extern void HideWindow(IntPtr window);
		
		[DllImport(SdlName, EntryPoint = "SDL_RaiseWindow")]
		public static extern void RaiseWindow(IntPtr window);
		
		[DllImport(SdlName, EntryPoint = "SDL_MaximizeWindow")]
		public static extern void MaximizeWindow(IntPtr window);
		
		[DllImport(SdlName, EntryPoint = "SDL_MinimizeWindow")]
		public static extern void MinimizeWindow(IntPtr window);
		
		[DllImport(SdlName, EntryPoint = "SDL_RestoreWindow")]
		public static extern void RestoreWindow(IntPtr window);
		
		[DllImport(SdlName, EntryPoint = "SDL_SetWindowFullscreen")]
		public static extern int SetWindowFullscreen(IntPtr window, SDL_WindowFlags flags);
		
		[DllImport(SdlName, EntryPoint = "SDL_GetWindowSurface")]
		public static extern IntPtr GetWindowSurface(IntPtr window);
		
		[DllImport(SdlName, EntryPoint = "SDL_UpdateWindowSurface")]
		public static extern int UpdateWindowSurface(IntPtr window);
		
		[DllImport(SdlName, EntryPoint = "SDL_IsScreenSaverEnabled")]
		public static extern bool IsScreenSaverEnabled();
		
		[DllImport(SdlName, EntryPoint = "SDL_EnableScreenSaver")]
		public static extern void EnableScreenSaver();
		
		[DllImport(SdlName, EntryPoint = "SDL_DisableScreenSaver")]
		public static extern void DisableScreenSaver();

	}
}