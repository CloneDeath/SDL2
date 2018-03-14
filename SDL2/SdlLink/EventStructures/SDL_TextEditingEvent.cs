using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_TextEditingEvent
	{
		public uint type;                                /**< ::SDL_TEXTEDITING */
		public uint timestamp;                           /**< In milliseconds, populated using SDL_GetTicks() */
		public uint windowID;                            /**< The window with keyboard focus, if any */
		
		[MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
		public char[] text;  /**< The editing text */
		public int start;                               /**< The start cursor of selected editing text */
		public int length;                              /**< The length of selected editing text */
	}
}