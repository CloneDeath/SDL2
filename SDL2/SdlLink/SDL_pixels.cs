using System;
using System.Runtime.InteropServices;

namespace SDL2.SdlLink {
	public static partial class Sdl {
		[DllImport(SdlName, EntryPoint = "SDL_GetRGBA")]
		public static extern void GetRgba(uint pixel, IntPtr format, out byte r, out byte g, out byte b, out byte a);
		
		[DllImport(SdlName, EntryPoint = "SDL_MapRGBA")]
		public static extern uint MapRgba(IntPtr format, byte r, byte g, byte b, byte a);
	}
}