using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_DollarGestureEvent
	{
		public uint type;        /**< ::SDL_DOLLARGESTURE or ::SDL_DOLLARRECORD */
		public uint timestamp;   /**< In milliseconds, populated using SDL_GetTicks() */
		public long touchId; /**< The touch device id */
		public long gestureId;
		public uint numFingers;
		public float error;
		public float x;            /**< Normalized center of gesture */
		public float y;            /**< Normalized center of gesture */
	}
}