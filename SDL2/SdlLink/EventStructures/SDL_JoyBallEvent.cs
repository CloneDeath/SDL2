using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_JoyBallEvent
	{
		public uint type;        /**< ::SDL_JOYBALLMOTION */
		public uint timestamp;   /**< In milliseconds, populated using SDL_GetTicks() */
		public int which; /**< The joystick instance id */
		public byte ball;         /**< The joystick trackball index */
		public byte padding1;
		public byte padding2;
		public byte padding3;
		public short xrel;        /**< The relative motion in the X direction */
		public short yrel;        /**< The relative motion in the Y direction */
	}
}