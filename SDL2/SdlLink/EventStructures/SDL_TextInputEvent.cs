using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_TextInputEvent
	{
		public uint type;                              /**< ::SDL_TEXTINPUT */
		public uint timestamp;                         /**< In milliseconds, populated using SDL_GetTicks() */
		public uint windowID;                          /**< The window with keyboard focus, if any */
		[MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
		public char[] text;  /**< The input text */
	}
}