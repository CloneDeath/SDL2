using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_JoyButtonEvent
	{
		public uint type;        /**< ::SDL_JOYBUTTONDOWN or ::SDL_JOYBUTTONUP */
		public uint timestamp;   /**< In milliseconds, populated using SDL_GetTicks() */
		public int which; /**< The joystick instance id */
		public byte button;       /**< The joystick button index */
		public byte state;        /**< ::SDL_PRESSED or ::SDL_RELEASED */
		public byte padding1;
		public byte padding2;
	}
}