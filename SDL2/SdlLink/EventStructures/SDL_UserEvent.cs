using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_UserEvent
	{
		public uint type;        /**< ::SDL_USEREVENT through ::SDL_LASTEVENT-1 */
		public uint timestamp;   /**< In milliseconds, populated using SDL_GetTicks() */
		public uint windowID;    /**< The associated window if any */
		public int code;        /**< User defined event code */
		public IntPtr data1;        /**< User defined data pointer */
		public IntPtr data2;        /**< User defined data pointer */
	}
}