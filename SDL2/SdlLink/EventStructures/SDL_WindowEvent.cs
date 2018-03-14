// ReSharper disable InconsistentNaming

using System.Runtime.InteropServices;

namespace SDL2.SdlLink.EventStructures {
	/// <summary>
	/// Window state change event data (event.window.*)
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_WindowEvent
	{
		public uint type;        /**< ::SDL_WINDOWEVENT */
		public uint timestamp;   /**< In milliseconds, populated using SDL_GetTicks() */
		public uint windowID;    /**< The associated window */
		public byte Event;        /**< ::SDL_WindowEventID */
		public byte padding1;
		public byte padding2;
		public byte padding3;
		public int data1;       /**< event dependent data */
		public int data2;       /**< event dependent data */
	}
}