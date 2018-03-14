using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_ControllerDeviceEvent
	{
		public uint type;        /**< ::SDL_CONTROLLERDEVICEADDED, ::SDL_CONTROLLERDEVICEREMOVED, or ::SDL_CONTROLLERDEVICEREMAPPED */
		public uint timestamp;   /**< In milliseconds, populated using SDL_GetTicks() */
		public int which;       /**< The joystick device index for the ADDED event, instance id for the REMOVED or REMAPPED event */
	}
}