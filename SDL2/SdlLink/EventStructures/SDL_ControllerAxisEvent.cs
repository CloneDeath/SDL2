using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_ControllerAxisEvent
	{
		public uint type;        /**< ::SDL_CONTROLLERAXISMOTION */
		public uint timestamp;   /**< In milliseconds, populated using SDL_GetTicks() */
		public int which; /**< The joystick instance id */
		public byte axis;         /**< The controller axis (SDL_GameControllerAxis) */
		public byte padding1;
		public byte padding2;
		public byte padding3;
		public short value;       /**< The axis value (range: -32768 to 32767) */
		public ushort padding4;
	}
}