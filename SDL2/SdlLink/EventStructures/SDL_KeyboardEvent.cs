using System.Runtime.InteropServices;
using SDL2.SdlLink.EventStructures.Keyboard;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures {
	/// <summary>
	/// Keyboard button event structure (event.key.*)
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_KeyboardEvent
	{
		public uint type;        /**< ::SDL_KEYDOWN or ::SDL_KEYUP */
		public uint timestamp;   /**< In milliseconds, populated using SDL_GetTicks() */
		public uint windowID;    /**< The window with keyboard focus, if any */
		public byte state;        /**< ::SDL_PRESSED or ::SDL_RELEASED */
		public byte repeat;       /**< Non-zero if this is a key repeat */
		public byte padding2;
		public byte padding3;
		public SDL_Keysym keysym;  /**< The key that was pressed or released */
	}
}