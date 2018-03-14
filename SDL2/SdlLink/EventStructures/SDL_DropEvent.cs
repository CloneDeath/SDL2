using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_DropEvent {
		public uint type; /**< ::SDL_DROPBEGIN or ::SDL_DROPFILE or ::SDL_DROPTEXT or ::SDL_DROPCOMPLETE */
		public uint timestamp; /**< In milliseconds, populated using SDL_GetTicks() */
		public IntPtr file; /**< The file name, which should be freed with SDL_free(), is NULL on begin/complete */
		public uint windowID; /**< The window that was dropped on, if any */
	}
}