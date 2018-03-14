using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_MultiGestureEvent
	{
		public uint type;        /**< ::SDL_MULTIGESTURE */
		public uint timestamp;   /**< In milliseconds, populated using SDL_GetTicks() */
		public long touchId; /**< The touch device id */
		public float dTheta;
		public float dDist;
		public float x;
		public float y;
		public ushort numFingers;
		public ushort padding;
	}
}