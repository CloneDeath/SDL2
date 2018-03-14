using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_OSEvent
	{
		public uint type;        /**< ::SDL_QUIT */
		public uint timestamp;   /**< In milliseconds, populated using SDL_GetTicks() */
	}
}