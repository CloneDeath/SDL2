using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_MouseButtonEvent
	{
		public uint type;        /**< ::SDL_MOUSEBUTTONDOWN or ::SDL_MOUSEBUTTONUP */
		public uint timestamp;   /**< In milliseconds, populated using SDL_GetTicks() */
		public uint windowID;    /**< The window with mouse focus, if any */
		public uint which;       /**< The mouse instance id, or SDL_TOUCH_MOUSEID */
		public byte button;       /**< The mouse button index */
		public byte state;        /**< ::SDL_PRESSED or ::SDL_RELEASED */
		public byte clicks;       /**< 1 for single-click, 2 for double-click, etc. */
		public byte padding1;
		public int x;           /**< X coordinate, relative to window */
		public int y;           /**< Y coordinate, relative to window */
	}
}