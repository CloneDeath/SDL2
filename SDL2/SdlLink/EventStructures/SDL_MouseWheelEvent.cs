using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_MouseWheelEvent
	{
		public uint type;        /**< ::SDL_MOUSEWHEEL */
		public uint timestamp;   /**< In milliseconds, populated using SDL_GetTicks() */
		public uint windowID;    /**< The window with mouse focus, if any */
		public uint which;       /**< The mouse instance id, or SDL_TOUCH_MOUSEID */
		public int x;           /**< The amount scrolled horizontally, positive to the right and negative to the left */
		public int y;           /**< The amount scrolled vertically, positive away from the user and negative toward the user */
		public uint direction;   /**< Set to one of the SDL_MOUSEWHEEL_* defines. When FLIPPED the values in X and Y will be opposite. Multiply by -1 to change them back */
	}
}