using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_MouseMotionEvent
	{
		public uint type;        /**< ::SDL_MOUSEMOTION */
		public uint timestamp;   /**< In milliseconds, populated using SDL_GetTicks() */
		public uint windowID;    /**< The window with mouse focus, if any */
		public uint which;       /**< The mouse instance id, or SDL_TOUCH_MOUSEID */
		public uint state;       /**< The current button state */
		public int x;           /**< X coordinate, relative to window */
		public int y;           /**< Y coordinate, relative to window */
		public int xrel;        /**< The relative motion in the X direction */
		public int yrel;        /**< The relative motion in the Y direction */
	}
}