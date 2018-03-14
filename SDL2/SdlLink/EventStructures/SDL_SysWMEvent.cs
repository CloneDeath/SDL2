using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures {
	/// <summary>
	/// A video driver dependent system event (event.syswm.*)
	/// This event is disabled by default, you can enable it with SDL_EventState()
	/// If you want to use this event, you should include SDL_syswm.h.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_SysWMEvent
	{
		public uint type;        /**< ::SDL_SYSWMEVENT */
		public uint timestamp;   /**< In milliseconds, populated using SDL_GetTicks() */
		public IntPtr msg;  /**< driver dependent data, defined in SDL_syswm.h */
	}
}