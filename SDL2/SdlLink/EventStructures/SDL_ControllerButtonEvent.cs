using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_ControllerButtonEvent
	{
		public uint type;        /**< ::SDL_CONTROLLERBUTTONDOWN or ::SDL_CONTROLLERBUTTONUP */
		public uint timestamp;   /**< In milliseconds, populated using SDL_GetTicks() */
		public int which; /**< The joystick instance id */
		public byte button;       /**< The controller button (SDL_GameControllerButton) */
		public byte state;        /**< ::SDL_PRESSED or ::SDL_RELEASED */
		public byte padding1;
		public byte padding2;
	}
}